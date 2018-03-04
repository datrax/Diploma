using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Contract.DTOModel;
using DAL;
using DAL.EF;
using Newtonsoft.Json;

namespace BLL
{
    public class Services
    {
        private IUnitOfWork unitOfWork;
        private IMapper autoMapper;
        public Services()
        {
            autoMapper = AutoMapper.Mapper.Instance;
            unitOfWork = new UnitOfWork<ModelContext>();
        }

        static Services()
        {
            AutomapperConfig.InitializeAutomapper();
        }
        public IEnumerable<ObjectsDTO> GetObjects()
        {
            return autoMapper.Map<List<ObjectsDTO>>(unitOfWork.GetRepository<objects>().GetAll().ToList());
        }
        public IEnumerable<SectorsDTO> GetSectors()
        {
            return autoMapper.Map<List<SectorsDTO>>(unitOfWork.GetRepository<sectors>().GetAll().ToList());
        }

        public IEnumerable<WellsDTO> GetWells()
        {
            return autoMapper.Map<List<WellsDTO>>(unitOfWork.GetRepository<wells>().GetAll().ToList());
        }

        public ObjectsDTO GetObjectById(int id)
        {
            return autoMapper.Map<ObjectsDTO>(unitOfWork.GetRepository<objects>().GetById(id));
        }
        public SectorsDTO GetSectorById(int id)
        {
            return autoMapper.Map<SectorsDTO>(unitOfWork.GetRepository<sectors>().GetById(id));
        }
        public WellsDTO GetWellById(int id)
        {
            return autoMapper.Map<WellsDTO>(unitOfWork.GetRepository<wells>().GetById(id));
        }
        public string GetItemsPath(int id, string type)
        {

            if (type ==  "WellsDTO")
            {                
                var well = unitOfWork.GetRepository<wells>().GetById(id);                                               
                string ans = well.sectors.objects.name + "/" + well.sectors.name + "/" + well.char_name;
                return ans;
            }

            if (type == "SectorsDTO")
            {
                var sector = unitOfWork.GetRepository<sectors>().GetById(id);
                string ans = sector.objects.name + "/" + sector.name;
                return ans;
            }

            if (type == "ObjectsDTO")
            {
                var @object = unitOfWork.GetRepository<objects>().GetById(id);
                string ans = @object.name + "/";
                return ans;
            }
            return "";
        }


        public IEnumerable<DocumentsDTO> GetDocuments(int id, string type, int userId)
        {

            if (type == "SectorsDTO")
            {
                var config =
                    new MapperConfiguration(
                        cfg =>
                            cfg.CreateMap<sectors_documents, DocumentsDTO>()
                                .ForMember(a => a.AuthorName, o => o.MapFrom(s => GetAuthor(s.Author.Value))).ForMember(a => a.ParentId, o => o.MapFrom(s => s.SectorId)).ForMember(a => a.LastChangeUserName, o => o.MapFrom(s => s.LastChangeUser != null ? GetAuthor(s.LastChangeUser.Value) : "")));
                var mapper = config.CreateMapper();
                var admin = IsAdmin(userId);
                return
                    mapper.Map<List<DocumentsDTO>>(
                        unitOfWork.GetRepository<sectors_documents>().Find(a => a.SectorId == id && (!a.IsPrivate || userId == a.Author || admin))).ToList();
            }
            if (type == "ObjectsDTO")
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
                        unitOfWork.GetRepository<objects_documents>().Find(a => a.ObjectId == id && (!a.IsPrivate || userId == a.Author || admin))).ToList();
            }
            if (type == "WellsDTO")
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
        public int getFirstEntry(string source, string template)
        {
            int sourceLen = source.Length;
            int templateLen = template.Length;
            if (templateLen > sourceLen)
            {
                return -1;
            }
            Dictionary<char, int> offsetTable = new Dictionary<char, int>();
            for (int index = 0; index <= 255; index++)
            {
                if (offsetTable.ContainsKey((char)index))
                {
                    offsetTable[(char)index] = templateLen;
                }
                else
                {
                    offsetTable.Add((char)index, templateLen);
                }
            }
            for (int index = 0; index < templateLen - 1; index++)
            {
                if (offsetTable.ContainsKey(template[index]))
                {
                    offsetTable[template[index]] = templateLen - index - 1;
                }
                else
                {
                    offsetTable.Add(template[index], templateLen - index - 1);
                }
            }
            int i = templateLen - 1;
            int j = i;
            int k = i;
            while (j >= 0 && i <= sourceLen - 1)
            {
                j = templateLen - 1;
                k = i;
                while (j >= 0 && source[k] == template[j])
                {
                    k--;
                    j--;
                }
                if (offsetTable.ContainsKey(source[i]))
                {
                    i += offsetTable[source[i]];
                }
                else
                {
                    i += templateLen;
                }

            }
            if (k >= sourceLen - templateLen)
            {
                return -1;
            }
            else
            {
                return k + 1;
            }
        }

        public IEnumerable<SearchStruct> GetListOfAvailableDocs(int userId)
        {
            var admin = IsAdmin(userId);
            var ids = unitOfWork.GetRepository<sectors_documents>()
                .Find(a => !a.IsPrivate || userId == a.Author || admin)
                .Select(a => new SearchStruct(a.id, "SectorsDTO", a.Name, null, a.SectorId)).ToList();
            ids.AddRange(
                unitOfWork.GetRepository<wells_documents>()
                    .Find(a => !a.IsPrivate || userId == a.Author || admin)
                    .Select(a => new SearchStruct(a.id, "WellsDTO", a.Name, null, a.WellId)).ToList());
            ids.AddRange(
                unitOfWork.GetRepository<objects_documents>()
                    .Find(a => !a.IsPrivate || userId == a.Author || admin)
                    .Select(a => new SearchStruct(a.id, "ObjectsDTO", a.Name, null, a.ObjectId)).ToList());
            return ids;
        }

        static Dictionary<string, SearchStruct> RedisClientLocalCache = new Dictionary<string, SearchStruct>();

        public class SearchStruct
        {
            public int Id { get; set; }        
            public string Type { get; set; }
            public string Name { get; set; }
            public string Content { get; set; }
            public int ParentId { get; set; }
            public SearchStruct(int id, string type, string name, string content, int parentId)
            {
                Id = id;
                Type = type;
                Name = name;
                Content = content;
                ParentId = parentId;
            }

            public override bool Equals(object obj)
            {
                SearchStruct ob = obj as SearchStruct;
                return ob.Id == Id && ob.Type == Type && ob.Name == Name && ob.Content == Content;
            }

            public override int GetHashCode()
            {
                return Id.GetHashCode() ^ Type.GetHashCode();
            }
        }
        private IEnumerable<SearchStruct> GetDocsSearchContent(IEnumerable<SearchStruct> docs)
        {
            foreach (var sd in docs)
            {
                var key = sd.Type + sd.Id;
                if (!RedisClientLocalCache.ContainsKey(key))
                {
                    sd.Content = unitOfWork.RedisRepository.Get(key + "search");
                    RedisClientLocalCache.Add(key, sd);
                    yield return sd;
                }
                else
                {
                    yield return RedisClientLocalCache[key];
                }
            }
        }
        public List<string> GetHints(int userId, string template)
        {
            HashSet<string> resList = new HashSet<string>();
            var docsId = GetListOfAvailableDocs(userId).ToList();
            var docs = GetDocsSearchContent(docsId.ToList());
            Parallel.ForEach(docs, doc =>
            {
                if (doc.Name.Contains(template))
                {
                    resList.Add(doc.Name);
                }
                if (doc.Content == null)
                {
                    return;
                }
                var e = getFirstEntry(doc.Content, template);
                if (e < 0 || e + 10 >= doc.Content.Length)
                {
                    return;
                }

                resList.Add(doc.Content.Substring(e, 10));
            });
            return resList.ToList();
        }
        public List<SearchStruct> GetListOfFoundDocs(int userId, string template)
        {
            HashSet<SearchStruct> resList = new HashSet<SearchStruct>();
            var docsId = GetListOfAvailableDocs(userId).ToList();
            var docs = GetDocsSearchContent(docsId.ToList());
            Parallel.ForEach(docs, doc =>
            {
                if (doc.Name.Contains(template))
                {
                    resList.Add(new SearchStruct(doc.Id, doc.Type, null, null, doc.ParentId));
                }
                if (doc.Content == null)
                {
                    return;
                }
                var e = getFirstEntry(doc.Content, template);
                if (e < 0 || e + 10 >= doc.Content.Length)
                {
                    return;
                }
                resList.Add(new SearchStruct(doc.Id, doc.Type, null, null, doc.ParentId));
            });
            return resList.ToList();
        }

        public List<FoundDocumentsDto> FoundDocs(int userId, string template)
        {
            List<SearchStruct> docs = GetListOfFoundDocs(userId, template);
            var result = new List<FoundDocumentsDto>();
            foreach (var doc in docs)
            {
                if (doc.Type == "SectorsDTO")
                {
                    var file = unitOfWork.GetRepository<sectors_documents>().GetById(doc.Id);
                    result.Add(new FoundDocumentsDto()
                    {
                        id = file.id,
                        Type = doc.Type,
                        Name = file.Name,
                        AuthorName = file.Author != null ? GetAuthor(file.Author.Value) : "",
                        LastChangeUserName = file.LastChangeUser != null ? GetAuthor(file.LastChangeUser.Value) : "",
                        Version = file.Version,
                        dateTime = file.DateTime,
                        ParentId = file.SectorId,
                        Path = GetItemsPath(doc.ParentId, doc.Type)
                    });
                }
                if (doc.Type == "ObjectsDTO")
                {
                    var file = unitOfWork.GetRepository<objects_documents>().GetById(doc.Id);
                    result.Add(new FoundDocumentsDto()
                    {
                        id = file.id,
                        Type = doc.Type,
                        Name = file.Name,
                        AuthorName = file.Author != null ? GetAuthor(file.Author.Value) : "",
                        LastChangeUserName = file.LastChangeUser != null ? GetAuthor(file.LastChangeUser.Value) : "",
                        Version = file.Version,
                        dateTime = file.DateTime,
                        ParentId = file.ObjectId,
                        Path = GetItemsPath(doc.ParentId, doc.Type)

                    });
                }
                if (doc.Type == "WellsDTO")
                {
                    var file = unitOfWork.GetRepository<wells_documents>().GetById(doc.Id);
                    result.Add(new FoundDocumentsDto()
                    {
                        id = file.id,
                        Type = doc.Type,
                        Name = file.Name,
                        AuthorName = file.Author != null ? GetAuthor(file.Author.Value) : "",
                        LastChangeUserName = file.LastChangeUser != null ? GetAuthor(file.LastChangeUser.Value) : "",
                        Version = file.Version,
                        dateTime = file.DateTime,
                        ParentId = file.WellId,
                        Path = GetItemsPath(doc.ParentId, doc.Type)

                    });
                }
            }
            return result;
        }
        static IEnumerable<string> Split(string str, int chunkSize)
        {
            if (str.Length < chunkSize)
            {
                return new[] { str };
            }
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
        public void AddFile(string shortName, int authorId, string version, byte[] bytes, int sectorId, bool isPrivate, bool canBeEdited, string type)
        {

            if (type == "SectorsDTO")
            {
                var doc = new sectors_documents()
                {
                    BeingEdited = false,
                    Name = shortName,
                    Author = authorId,
                    SectorId = sectorId,
                    Version = version,
                    DateTime = DateTime.Now,
                    IsPrivate = isPrivate,
                    UsersCanEdit = canBeEdited
                };

                unitOfWork.GetRepository<sectors_documents>().Add(doc);
                unitOfWork.Save();
                unitOfWork.RedisRepository.Set(type + doc.id, System.Text.Encoding.Default.GetString(bytes));
                var text = RS.TextExtractor.Extractor.ExtractTextFromFile(shortName, bytes);
                unitOfWork.RedisRepository.Set(type + doc.id + "search", text);
            }
            if (type == "ObjectsDTO")
            {
                var doc = new objects_documents()
                {
                    BeingEdited = false,
                    Name = shortName,
                    Author = authorId,
                    ObjectId = sectorId,
                    Version = version,
                    DateTime = DateTime.Now,
                    IsPrivate = isPrivate,
                    UsersCanEdit = canBeEdited
                };

                unitOfWork.GetRepository<objects_documents>().Add(doc);
                unitOfWork.Save();
                unitOfWork.RedisRepository.Set(type + doc.id, System.Text.Encoding.Default.GetString(bytes));
                var text = RS.TextExtractor.Extractor.ExtractTextFromFile(shortName, bytes);
                unitOfWork.RedisRepository.Set(type + doc.id + "search", text);
            }
            if (type == "WellsDTO")
            {
                var doc = new wells_documents()
                {
                    BeingEdited = false,
                    Name = shortName,
                    Author = authorId,
                    WellId = sectorId,
                    Version = version,
                    DateTime = DateTime.Now,
                    IsPrivate = isPrivate,
                    UsersCanEdit = canBeEdited
                };

                unitOfWork.GetRepository<wells_documents>().Add(doc);
                unitOfWork.Save();
                unitOfWork.RedisRepository.Set(type + doc.id, System.Text.Encoding.Default.GetString(bytes));
                var text = RS.TextExtractor.Extractor.ExtractTextFromFile(shortName, bytes);
                unitOfWork.RedisRepository.Set(type + doc.id + "search", text);
            }

        }

        public void EditDocument(DocumentsDTO doc, string type)
        {
            if (type == "SectorsDTO")
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
            if (type == "ObjectsDTO")
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
            if (type == "WellsDTO")
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
        public void DeleteFile(int id, string type)
        {
            if (type == "SectorsDTO")
            {
                var doc = unitOfWork.GetRepository<sectors_documents>().GetById(id);
                unitOfWork.RedisRepository.Delete(type + doc.id);
                unitOfWork.RedisRepository.Delete(type + doc.id + "search");
                unitOfWork.GetRepository<sectors_documents>().Delete(doc);
                unitOfWork.Save();
            }
            if (type == "ObjectsDTO")
            {
                var doc = unitOfWork.GetRepository<objects_documents>().GetById(id);
                unitOfWork.RedisRepository.Delete(type + doc.id);
                unitOfWork.RedisRepository.Delete(type + doc.id + "search");
                unitOfWork.GetRepository<objects_documents>().Delete(doc);
                unitOfWork.Save();
            }
            if (type == "WellsDTO")
            {
                var doc = unitOfWork.GetRepository<wells_documents>().GetById(id);
                unitOfWork.RedisRepository.Delete(type + doc.id + "search");
                unitOfWork.RedisRepository.Delete(type + doc.id);
                unitOfWork.GetRepository<wells_documents>().Delete(doc);
                unitOfWork.Save();
            }
        }
        public byte[] GetDocumentByid(int id, string type)
        {
            var doc = unitOfWork.RedisRepository.Get(type + id);
            return System.Text.Encoding.Default.GetBytes(doc);
        }

        public void SetNewDocData(DocumentsDTO doc, string type, byte[] data)
        {
            if (type == "SectorsDTO")
            {
                var docum = unitOfWork.GetRepository<sectors_documents>().GetById(doc.id);
                docum.BeingEdited = false;
                docum.UserThatEdits = doc.UserThatEdits;
                docum.LastChangeUser = doc.LastChangeUser;
                unitOfWork.GetRepository<sectors_documents>().Update(docum);
                unitOfWork.RedisRepository.Set(type + doc.id, System.Text.Encoding.Default.GetString(data));
                unitOfWork.Save();
                var text = RS.TextExtractor.Extractor.ExtractTextFromFile(doc.Name, data);
                unitOfWork.RedisRepository.Set(type + doc.id + "search", text);
            }
            if (type == "ObjectsDTO")
            {
                var docum = unitOfWork.GetRepository<objects_documents>().GetById(doc.id);
                docum.BeingEdited = false;
                docum.UserThatEdits = doc.UserThatEdits;
                docum.LastChangeUser = doc.LastChangeUser;
                unitOfWork.GetRepository<objects_documents>().Update(docum);
                unitOfWork.RedisRepository.Set(type + doc.id, System.Text.Encoding.Default.GetString(data));
                unitOfWork.Save();
                var text = RS.TextExtractor.Extractor.ExtractTextFromFile(doc.Name, data);
                unitOfWork.RedisRepository.Set(type + doc.id + "search", text);
            }
            if (type == "WellsDTO")
            {
                var docum = unitOfWork.GetRepository<wells_documents>().GetById(doc.id);
                docum.BeingEdited = false;
                docum.UserThatEdits = doc.UserThatEdits;
                docum.LastChangeUser = doc.LastChangeUser;
                unitOfWork.GetRepository<wells_documents>().Update(docum);
                unitOfWork.RedisRepository.Set(type + doc.id, System.Text.Encoding.Default.GetString(data));
                unitOfWork.Save();
                var text = RS.TextExtractor.Extractor.ExtractTextFromFile(doc.Name, data);
                unitOfWork.RedisRepository.Set(type + doc.id + "search", text);
            }
        }
        public bool IsAdmin(int id)
        {
            if (id == -1)
                return false;
            if (unitOfWork.GetRepository<performers>().GetById(id).performers_roles.Any(a => a.role_id == 0))
                return true;
            return false;
        }
        public bool UserCanEditData(int id)
        {
            if (id == -1)
                return false;
            if (unitOfWork.GetRepository<performers>().GetById(id).performers_roles.Any(a => a.role_id == 1))
                return true;
            return false;
        }
    }
}
