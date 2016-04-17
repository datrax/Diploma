using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOModel;
using DAL;
using DAL.EF;

namespace BLL
{
    public class Services
    {
        private IUnitOfWork unitOfWork;
        public Services()
        {
            unitOfWork = new UnitOfWork<ModelContext>();
        }
        public IEnumerable<ObjectsDTO> GetObjects()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<objects, ObjectsDTO>());
            var mapper = config.CreateMapper();
            return mapper.Map<List<ObjectsDTO>>(unitOfWork.GetRepository<objects>().GetAll().ToList());
        }
        public IEnumerable<SectorsDTO> GetSectors()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<sectors, SectorsDTO>().ForMember(a => a.objectName, o => o.MapFrom(s => s.objects.name)));
            var mapper = config.CreateMapper();
            return mapper.Map<List<SectorsDTO>>(unitOfWork.GetRepository<sectors>().GetAll().ToList());
        }

        public IEnumerable<WellsDTO> GetWells()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<wells, WellsDTO>().ForMember(a => a.sector_name, o => o.MapFrom(s => s.sectors.name)));
            var mapper = config.CreateMapper();
            return mapper.Map<List<WellsDTO>>(unitOfWork.GetRepository<wells>().GetAll().ToList());
        }
        public  string GetItemsPath(object rowObject)
        {
        
            if (rowObject is WellsDTO)
            {
                string ans = "";
                var t= (rowObject as WellsDTO);
                ans+=unitOfWork.GetRepository<sectors>().GetById(t.sector_id.Value).objects.name;
                ans += "/"+t.sector_name+"/"+t.char_name;
                return ans;
            }

            if (rowObject is SectorsDTO)
            {
                string ans = "";
                var t = (rowObject as SectorsDTO);
                ans +=  t.name+ "/" + t.objectName;
                return ans;
            }

            if (rowObject is ObjectsDTO)
            {
                string ans = "";
                var t = (rowObject as ObjectsDTO);
                ans += t.name;
                return ans;
            }
            return "";
        }
        public static string GetItemAsString(object rowObject)
        {

            if (rowObject is WellsDTO)
                return (rowObject as WellsDTO).ToString();

            if (rowObject is SectorsDTO)
                return (rowObject as SectorsDTO).ToString();

            if (rowObject is ObjectsDTO)
                return (rowObject as ObjectsDTO).ToString();
            if (rowObject is DocumentsDTO)
                return (rowObject as DocumentsDTO).dateTime.ToString();
            return "";
        }

        public IEnumerable<DocumentsDTO> GetDocuments(int id, Type type,int userId)
        {
          
            if (type.Name == "SectorsDTO")
            {
                var config =
                    new MapperConfiguration(
                        cfg =>
                            cfg.CreateMap<sectors_documents, DocumentsDTO>()
                                .ForMember(a => a.AuthorName, o => o.MapFrom(s => GetAuthor(s.Author.Value))).ForMember(a => a.ParentId, o => o.MapFrom(s => s.SectorId)).ForMember(a => a.LastChangeUserName, o => o.MapFrom(s => s.LastChangeUser!=null?GetAuthor(s.LastChangeUser.Value):"")));
                var mapper = config.CreateMapper();
                var admin = IsAdmin(userId);
                return
                    mapper.Map<List<DocumentsDTO>>(
                        unitOfWork.GetRepository<sectors_documents>().Find(a => a.SectorId == id && (!a.IsPrivate || userId == a.Author || admin))).ToList();
            }
            if (type.Name == "ObjectsDTO")
            {
                var config =
                    new MapperConfiguration(
                        cfg =>
                            cfg.CreateMap<objects_documents, DocumentsDTO>()
                                .ForMember(a => a.AuthorName, o => o.MapFrom(s => GetAuthor(s.Author.Value))).ForMember(a => a.ParentId, o => o.MapFrom(s => s.ObjectId)).ForMember(a => a.LastChangeUserName, o => o.MapFrom(s => s.LastChangeUser != null ? GetAuthor(s.LastChangeUser.Value) : "")));
                var mapper = config.CreateMapper();
                var admin = IsAdmin(userId);
                return
                    mapper.Map<List<DocumentsDTO>>(
                        unitOfWork.GetRepository<objects_documents>().Find(a => a.ObjectId == id&&(!a.IsPrivate || userId == a.Author || admin))).ToList();
            }
            if (type.Name == "WellsDTO")
            {
                var config =
                    new MapperConfiguration(
                        cfg =>
                            cfg.CreateMap<wells_documents, DocumentsDTO>()
                                .ForMember(a => a.AuthorName, o => o.MapFrom(s => GetAuthor(s.Author.Value))).ForMember(a => a.ParentId, o => o.MapFrom(s => s.WellId)).ForMember(a => a.LastChangeUserName, o => o.MapFrom(s => s.LastChangeUser != null ? GetAuthor(s.LastChangeUser.Value) : "")));
                var mapper = config.CreateMapper();
                var admin = IsAdmin(userId);
                return
                    mapper.Map<List<DocumentsDTO>>(
                        unitOfWork.GetRepository<wells_documents>().Find(a => a.WellId == id && (!a.IsPrivate || userId == a.Author || admin))).ToList();
            }
            return null;
        }

        public void AddFile(string shortName, int authorId, string version,byte[] bytes, int sectorId,bool isPrivate,bool canBeEdited, Type type)
        {
            if (type.Name == "SectorsDTO")
            {
                var doc = new sectors_documents()
                {
                    BeingEdited = false,
                    Name = shortName,
                    Author = authorId,
                    Data = bytes,
                    SectorId = sectorId,
                    Version = version,
                    DateTime = DateTime.Now,
                    IsPrivate = isPrivate,
                    UsersCanEdit = canBeEdited
                };

                unitOfWork.GetRepository<sectors_documents>().Add(doc);
                unitOfWork.Save();
            }
            if (type.Name == "ObjectsDTO")
            {
                var doc = new objects_documents()
                {
                    BeingEdited = false,
                    Name = shortName,
                    Author = authorId,
                    Data = bytes,
                    ObjectId = sectorId,
                    Version = version,
                    DateTime = DateTime.Now,
                    IsPrivate = isPrivate,
                    UsersCanEdit = canBeEdited
                };

                unitOfWork.GetRepository<objects_documents>().Add(doc);
                unitOfWork.Save();
            }
            if (type.Name == "WellsDTO")
            {
                var doc = new wells_documents()
                {
                    BeingEdited = false,
                    Name = shortName,
                    Author = authorId,
                    Data = bytes,
                    WellId = sectorId,
                    Version = version,
                    DateTime = DateTime.Now,
                    IsPrivate = isPrivate,
                    UsersCanEdit = canBeEdited
                };

                unitOfWork.GetRepository<wells_documents>().Add(doc);
                unitOfWork.Save();
            }
        }

        public void EditDocument(DocumentsDTO doc, Type type)
        {
            if (type.Name == "SectorsDTO")
            {
                var docum = unitOfWork.GetRepository<sectors_documents>().GetById(doc.id);
                docum.Name = doc.Name;
                docum.Version = doc.Version;
                docum.IsPrivate = doc.IsPrivate;
                docum.UsersCanEdit = doc.UsersCanEdit;
                docum.LastChangeUser = doc.LastChangeUser;
                docum.BeingEdited = doc.BeingEdited;
                docum.UserThatEdits = doc.UserThatEdits;
                unitOfWork.GetRepository<sectors_documents>().Update(docum);
                unitOfWork.Save();
            }
            if (type.Name == "ObjectsDTO")
            {
                var docum = unitOfWork.GetRepository<objects_documents>().GetById(doc.id);
                docum.Name = doc.Name;
                docum.Version = doc.Version;
                docum.IsPrivate = doc.IsPrivate;
                docum.UsersCanEdit = doc.UsersCanEdit;
                docum.LastChangeUser = doc.LastChangeUser;
                docum.BeingEdited = doc.BeingEdited;
                docum.UserThatEdits = doc.UserThatEdits;
                unitOfWork.GetRepository<objects_documents>().Update(docum);
                unitOfWork.Save();
            }
            if (type.Name == "WellsDTO")
            {
                var docum = unitOfWork.GetRepository<wells_documents>().GetById(doc.id);
                docum.Name = doc.Name;
                docum.Version = doc.Version;
                docum.IsPrivate = doc.IsPrivate;
                docum.UsersCanEdit = doc.UsersCanEdit;
                docum.LastChangeUser = doc.LastChangeUser;
                docum.BeingEdited = doc.BeingEdited;
                docum.UserThatEdits = doc.UserThatEdits;
                unitOfWork.GetRepository<wells_documents>().Update(docum);
                unitOfWork.Save();
            }
        }

        public string GetAuthor(int id)
        {
            return unitOfWork.GetRepository<performers>().GetById(id).fio;
        }
        public void DeleteFile(int id,Type type)
        {
            if (type.Name == "SectorsDTO")
            {
                var doc = unitOfWork.GetRepository<sectors_documents>().GetById(id);
                unitOfWork.GetRepository<sectors_documents>().Delete(doc);
                unitOfWork.Save();
            }
            if (type.Name == "ObjectsDTO")
            {
                var doc = unitOfWork.GetRepository<objects_documents>().GetById(id);
                unitOfWork.GetRepository<objects_documents>().Delete(doc);
                unitOfWork.Save();
            }
            if (type.Name == "WellsDTO")
            {
                var doc = unitOfWork.GetRepository<wells_documents>().GetById(id);
                unitOfWork.GetRepository<wells_documents>().Delete(doc);
                unitOfWork.Save();
            }
        }
        public byte[] GetDocumentByid(int id, Type type)
        {
            if (type.Name == "SectorsDTO")
            {
                return unitOfWork.GetRepository<sectors_documents>().GetById(id).Data;
            }
            if (type.Name == "ObjectsDTO")
            {
                return unitOfWork.GetRepository<objects_documents>().GetById(id).Data;
            }
            if (type.Name == "WellsDTO")
            {
                return unitOfWork.GetRepository<wells_documents>().GetById(id).Data;
            }
            return null;
        }

        public void SetNewDocData(DocumentsDTO doc, Type type,byte[] data)
        {
            if (type.Name == "SectorsDTO")
            {
                var docum = unitOfWork.GetRepository<sectors_documents>().GetById(doc.id);
                docum.Data = data;
                docum.BeingEdited = false;
                docum.UserThatEdits = doc.UserThatEdits;
                docum.LastChangeUser = doc.LastChangeUser;
                unitOfWork.GetRepository<sectors_documents>().Update(docum);
                unitOfWork.Save();
            }
            if (type.Name == "ObjectsDTO")
            {
                var docum = unitOfWork.GetRepository<objects_documents>().GetById(doc.id);
                docum.Data = data;
                docum.BeingEdited = false;
                docum.UserThatEdits = doc.UserThatEdits;
                docum.LastChangeUser = doc.LastChangeUser;
                unitOfWork.GetRepository<objects_documents>().Update(docum);
                unitOfWork.Save();
            }
            if (type.Name == "WellsDTO")
            {
                var docum = unitOfWork.GetRepository<wells_documents>().GetById(doc.id);
                docum.Data = data;
                docum.BeingEdited = false;
                docum.UserThatEdits = doc.UserThatEdits;
                docum.LastChangeUser = doc.LastChangeUser;
                unitOfWork.GetRepository<wells_documents>().Update(docum);
                unitOfWork.Save();
            }
        }
        public bool IsAdmin(int id)
        {
            if (unitOfWork.GetRepository<performers>().GetById(id).performers_roles.Any(a => a.role_id == 0))
                return true;
            return false;
        }
        public bool UserCanEditData(int id)
        {
            if (unitOfWork.GetRepository<performers>().GetById(id).performers_roles.Any(a => a.role_id == 1))
                return true;
            return false;
        }
    }
}
