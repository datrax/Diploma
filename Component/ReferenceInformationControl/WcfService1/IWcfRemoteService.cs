using System;
using System.Collections.Generic;
using System.ServiceModel;
using BLL.Contract.DTOModel;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWcfRemoteService" in both code and config file together.
    [ServiceContract]
    public interface IWcfRemoteService
    {
        [OperationContract]
        IEnumerable<ObjectsDTO> GetObjects();
        [OperationContract]
        IEnumerable<SectorsDTO> GetSectors();
        [OperationContract]
        IEnumerable<WellsDTO> GetWells();
        [OperationContract]
        ObjectsDTO GetObjectById(int id);
        [OperationContract]
        SectorsDTO GetSectorById(int id);
        [OperationContract]
        WellsDTO GetWellById(int id);
        [OperationContract]
        string GetItemsPath(int id, string type);
        [OperationContract]
        byte[] GetDocumentByid(int id, string type);
        [OperationContract]
        IEnumerable<DocumentsDTO> GetDocuments(int id, string type, int userId);
        [OperationContract]
        List<string> GetHints(int id, string template);
        [OperationContract]
        void AddFile(string shortName, int authorId, string version, byte[] bytes, int sectorId, bool isPrivate, bool canBeEdited, string type);
        [OperationContract]
        void EditDocument(DocumentsDTO doc, string type);
        [OperationContract]
        string GetAuthor(int id);
        [OperationContract]
        void DeleteFile(int id, string type);
        [OperationContract]
        void SetNewDocData(DocumentsDTO doc, string type, byte[] data);
        [OperationContract]
        bool IsAdmin(int id);
        [OperationContract]
        bool UserCanEditData(int id);
        [OperationContract]
        List<FoundDocumentsDto> FoundDocs(int userId, string template);
    }
}
