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

        public IEnumerable<DocumentsDTO> GetDocuments(int id, Type type)
        {
            if (type.Name == "SectorsDTO")
            {
                var config =
                    new MapperConfiguration(
                        cfg =>
                            cfg.CreateMap<sectors_documents, DocumentsDTO>()
                                .ForMember(a => a.AuthorName, o => o.MapFrom(s => GetAuthor(s.Author.Value))).ForMember(a => a.DocumentId, o => o.MapFrom(s => s.SectorId)));
                var mapper = config.CreateMapper();
                return
                    mapper.Map<List<DocumentsDTO>>(
                        unitOfWork.GetRepository<sectors_documents>().Find(a => a.SectorId == id)).ToList();
            }
            if (type.Name == "ObjectsDTO")
            {
                var config =
                    new MapperConfiguration(
                        cfg =>
                            cfg.CreateMap<objects_documents, DocumentsDTO>()
                                .ForMember(a => a.AuthorName, o => o.MapFrom(s => GetAuthor(s.Author.Value))).ForMember(a => a.DocumentId, o => o.MapFrom(s => s.ObjectId)));
                var mapper = config.CreateMapper();
                return
                    mapper.Map<List<DocumentsDTO>>(
                        unitOfWork.GetRepository<objects_documents>().Find(a => a.ObjectId == id)).ToList();
            }
            if (type.Name == "WellsDTO")
            {
                var config =
                    new MapperConfiguration(
                        cfg =>
                            cfg.CreateMap<wells_documents, DocumentsDTO>()
                                .ForMember(a => a.AuthorName, o => o.MapFrom(s => GetAuthor(s.Author.Value))).ForMember(a => a.DocumentId, o => o.MapFrom(s => s.WellId)));
                var mapper = config.CreateMapper();
                return
                    mapper.Map<List<DocumentsDTO>>(
                        unitOfWork.GetRepository<wells_documents>().Find(a => a.WellId == id)).ToList();
            }
            return null;
        }

        public void AddSectorDocument(string shortName, int authorId, byte[] bytes, int sectorId, Type type)
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
                    Version = "1.0",
                    DateTime = DateTime.Now,
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
                    Version = "1.0",
                    DateTime = DateTime.Now,
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
                    Version = "1.0",
                    DateTime = DateTime.Now,
                };

                unitOfWork.GetRepository<wells_documents>().Add(doc);
                unitOfWork.Save();
            }
        }

        public string GetAuthor(int id)
        {
            return unitOfWork.GetRepository<performers>().GetById(id).fio;
        }
    }
}
