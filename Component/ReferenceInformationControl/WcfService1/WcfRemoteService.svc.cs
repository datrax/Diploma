using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BLL;
using BLL.Contract.DTOModel;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfRemoteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WcfRemoteService.svc or WcfRemoteService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class WcfRemoteService : IWcfRemoteService
    {
        private Services services;
        public WcfRemoteService()
        {
            services = new Services();
        }

        public IEnumerable<ObjectsDTO> GetObjects()
        {
            return services.GetObjects();
        }
        public IEnumerable<SectorsDTO> GetSectors()
        {
            return services.GetSectors();
        }

        public IEnumerable<WellsDTO> GetWells()
        {
            return services.GetWells();
        }

        public ObjectsDTO GetObjectById(int id)
        {
            return services.GetObjectById(id);
        }
        public SectorsDTO GetSectorById(int id)
        {
            return services.GetSectorById(id);
        }
        public WellsDTO GetWellById(int id)
        {
            return services.GetWellById(id);
        }
        public byte[] GetDocumentByid(int id, string type)
        {
            return services.GetDocumentByid(id, type);
        }
        public string GetItemsPath(int id, string type)
        {

            return services.GetItemsPath(id, type);
        }

        public IEnumerable<DocumentsDTO> GetDocuments(int id, string type, int userId)
        {

            return services.GetDocuments(id, type, userId);
        }
        public int getFirstEntry(string source, string template)
        {
            return services.getFirstEntry(source, template);

        }

        public List<string> GetHints(int id, string template)
        {
            return services.GetHints(id, template);
        }
        public void AddFile(string shortName, int authorId, string version, byte[] bytes, int sectorId, bool isPrivate, bool canBeEdited, string type)
        {
            services.AddFile(shortName, authorId, version, bytes, sectorId, isPrivate, canBeEdited, type);
        }

        public void EditDocument(DocumentsDTO doc, string type)
        {
            services.EditDocument(doc, type);
        }

        public string GetAuthor(int id)
        {
            return services.GetAuthor(id);
        }
        public void DeleteFile(int id, string type)
        {
            services.DeleteFile(id, type);
        }

        public void SetNewDocData(DocumentsDTO doc, string type, byte[] data)
        {
            services.SetNewDocData(doc, type, data);
        }
        public bool IsAdmin(int id)
        {
            return services.IsAdmin(id);
        }
        public bool UserCanEditData(int id)
        {
            return services.UserCanEditData(id);
        }

        public List<FoundDocumentsDto> FoundDocs(int userId, string template)
        {
            return services.FoundDocs(userId, template);
        }
    }
}
