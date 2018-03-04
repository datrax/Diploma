﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReferenceInfoControl.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IWcfRemoteService")]
    public interface IWcfRemoteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetObjects", ReplyAction="http://tempuri.org/IWcfRemoteService/GetObjectsResponse")]
        BLL.Contract.DTOModel.ObjectsDTO[] GetObjects();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetObjects", ReplyAction="http://tempuri.org/IWcfRemoteService/GetObjectsResponse")]
        System.Threading.Tasks.Task<BLL.Contract.DTOModel.ObjectsDTO[]> GetObjectsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetSectors", ReplyAction="http://tempuri.org/IWcfRemoteService/GetSectorsResponse")]
        BLL.Contract.DTOModel.SectorsDTO[] GetSectors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetSectors", ReplyAction="http://tempuri.org/IWcfRemoteService/GetSectorsResponse")]
        System.Threading.Tasks.Task<BLL.Contract.DTOModel.SectorsDTO[]> GetSectorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetWells", ReplyAction="http://tempuri.org/IWcfRemoteService/GetWellsResponse")]
        BLL.Contract.DTOModel.WellsDTO[] GetWells();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetWells", ReplyAction="http://tempuri.org/IWcfRemoteService/GetWellsResponse")]
        System.Threading.Tasks.Task<BLL.Contract.DTOModel.WellsDTO[]> GetWellsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetObjectById", ReplyAction="http://tempuri.org/IWcfRemoteService/GetObjectByIdResponse")]
        BLL.Contract.DTOModel.ObjectsDTO GetObjectById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetObjectById", ReplyAction="http://tempuri.org/IWcfRemoteService/GetObjectByIdResponse")]
        System.Threading.Tasks.Task<BLL.Contract.DTOModel.ObjectsDTO> GetObjectByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetSectorById", ReplyAction="http://tempuri.org/IWcfRemoteService/GetSectorByIdResponse")]
        BLL.Contract.DTOModel.SectorsDTO GetSectorById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetSectorById", ReplyAction="http://tempuri.org/IWcfRemoteService/GetSectorByIdResponse")]
        System.Threading.Tasks.Task<BLL.Contract.DTOModel.SectorsDTO> GetSectorByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetWellById", ReplyAction="http://tempuri.org/IWcfRemoteService/GetWellByIdResponse")]
        BLL.Contract.DTOModel.WellsDTO GetWellById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetWellById", ReplyAction="http://tempuri.org/IWcfRemoteService/GetWellByIdResponse")]
        System.Threading.Tasks.Task<BLL.Contract.DTOModel.WellsDTO> GetWellByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetItemsPath", ReplyAction="http://tempuri.org/IWcfRemoteService/GetItemsPathResponse")]
        string GetItemsPath(int id, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetItemsPath", ReplyAction="http://tempuri.org/IWcfRemoteService/GetItemsPathResponse")]
        System.Threading.Tasks.Task<string> GetItemsPathAsync(int id, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetDocumentByid", ReplyAction="http://tempuri.org/IWcfRemoteService/GetDocumentByidResponse")]
        byte[] GetDocumentByid(int id, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetDocumentByid", ReplyAction="http://tempuri.org/IWcfRemoteService/GetDocumentByidResponse")]
        System.Threading.Tasks.Task<byte[]> GetDocumentByidAsync(int id, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetDocuments", ReplyAction="http://tempuri.org/IWcfRemoteService/GetDocumentsResponse")]
        BLL.Contract.DTOModel.DocumentsDTO[] GetDocuments(int id, string type, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetDocuments", ReplyAction="http://tempuri.org/IWcfRemoteService/GetDocumentsResponse")]
        System.Threading.Tasks.Task<BLL.Contract.DTOModel.DocumentsDTO[]> GetDocumentsAsync(int id, string type, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetHints", ReplyAction="http://tempuri.org/IWcfRemoteService/GetHintsResponse")]
        string[] GetHints(int id, string template);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetHints", ReplyAction="http://tempuri.org/IWcfRemoteService/GetHintsResponse")]
        System.Threading.Tasks.Task<string[]> GetHintsAsync(int id, string template);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/AddFile", ReplyAction="http://tempuri.org/IWcfRemoteService/AddFileResponse")]
        void AddFile(string shortName, int authorId, string version, byte[] bytes, int sectorId, bool isPrivate, bool canBeEdited, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/AddFile", ReplyAction="http://tempuri.org/IWcfRemoteService/AddFileResponse")]
        System.Threading.Tasks.Task AddFileAsync(string shortName, int authorId, string version, byte[] bytes, int sectorId, bool isPrivate, bool canBeEdited, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/EditDocument", ReplyAction="http://tempuri.org/IWcfRemoteService/EditDocumentResponse")]
        void EditDocument(BLL.Contract.DTOModel.DocumentsDTO doc, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/EditDocument", ReplyAction="http://tempuri.org/IWcfRemoteService/EditDocumentResponse")]
        System.Threading.Tasks.Task EditDocumentAsync(BLL.Contract.DTOModel.DocumentsDTO doc, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetAuthor", ReplyAction="http://tempuri.org/IWcfRemoteService/GetAuthorResponse")]
        string GetAuthor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/GetAuthor", ReplyAction="http://tempuri.org/IWcfRemoteService/GetAuthorResponse")]
        System.Threading.Tasks.Task<string> GetAuthorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/DeleteFile", ReplyAction="http://tempuri.org/IWcfRemoteService/DeleteFileResponse")]
        void DeleteFile(int id, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/DeleteFile", ReplyAction="http://tempuri.org/IWcfRemoteService/DeleteFileResponse")]
        System.Threading.Tasks.Task DeleteFileAsync(int id, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/SetNewDocData", ReplyAction="http://tempuri.org/IWcfRemoteService/SetNewDocDataResponse")]
        void SetNewDocData(BLL.Contract.DTOModel.DocumentsDTO doc, string type, byte[] data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/SetNewDocData", ReplyAction="http://tempuri.org/IWcfRemoteService/SetNewDocDataResponse")]
        System.Threading.Tasks.Task SetNewDocDataAsync(BLL.Contract.DTOModel.DocumentsDTO doc, string type, byte[] data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/IsAdmin", ReplyAction="http://tempuri.org/IWcfRemoteService/IsAdminResponse")]
        bool IsAdmin(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/IsAdmin", ReplyAction="http://tempuri.org/IWcfRemoteService/IsAdminResponse")]
        System.Threading.Tasks.Task<bool> IsAdminAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/UserCanEditData", ReplyAction="http://tempuri.org/IWcfRemoteService/UserCanEditDataResponse")]
        bool UserCanEditData(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/UserCanEditData", ReplyAction="http://tempuri.org/IWcfRemoteService/UserCanEditDataResponse")]
        System.Threading.Tasks.Task<bool> UserCanEditDataAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/FoundDocs", ReplyAction="http://tempuri.org/IWcfRemoteService/FoundDocsResponse")]
        BLL.Contract.DTOModel.FoundDocumentsDto[] FoundDocs(int userId, string template);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfRemoteService/FoundDocs", ReplyAction="http://tempuri.org/IWcfRemoteService/FoundDocsResponse")]
        System.Threading.Tasks.Task<BLL.Contract.DTOModel.FoundDocumentsDto[]> FoundDocsAsync(int userId, string template);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfRemoteServiceChannel : ReferenceInfoControl.ServiceReference.IWcfRemoteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfRemoteServiceClient : System.ServiceModel.ClientBase<ReferenceInfoControl.ServiceReference.IWcfRemoteService>, ReferenceInfoControl.ServiceReference.IWcfRemoteService {
        
        public WcfRemoteServiceClient() {
        }
        
        public WcfRemoteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfRemoteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfRemoteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfRemoteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BLL.Contract.DTOModel.ObjectsDTO[] GetObjects() {
            return base.Channel.GetObjects();
        }
        
        public System.Threading.Tasks.Task<BLL.Contract.DTOModel.ObjectsDTO[]> GetObjectsAsync() {
            return base.Channel.GetObjectsAsync();
        }
        
        public BLL.Contract.DTOModel.SectorsDTO[] GetSectors() {
            return base.Channel.GetSectors();
        }
        
        public System.Threading.Tasks.Task<BLL.Contract.DTOModel.SectorsDTO[]> GetSectorsAsync() {
            return base.Channel.GetSectorsAsync();
        }
        
        public BLL.Contract.DTOModel.WellsDTO[] GetWells() {
            return base.Channel.GetWells();
        }
        
        public System.Threading.Tasks.Task<BLL.Contract.DTOModel.WellsDTO[]> GetWellsAsync() {
            return base.Channel.GetWellsAsync();
        }
        
        public BLL.Contract.DTOModel.ObjectsDTO GetObjectById(int id) {
            return base.Channel.GetObjectById(id);
        }
        
        public System.Threading.Tasks.Task<BLL.Contract.DTOModel.ObjectsDTO> GetObjectByIdAsync(int id) {
            return base.Channel.GetObjectByIdAsync(id);
        }
        
        public BLL.Contract.DTOModel.SectorsDTO GetSectorById(int id) {
            return base.Channel.GetSectorById(id);
        }
        
        public System.Threading.Tasks.Task<BLL.Contract.DTOModel.SectorsDTO> GetSectorByIdAsync(int id) {
            return base.Channel.GetSectorByIdAsync(id);
        }
        
        public BLL.Contract.DTOModel.WellsDTO GetWellById(int id) {
            return base.Channel.GetWellById(id);
        }
        
        public System.Threading.Tasks.Task<BLL.Contract.DTOModel.WellsDTO> GetWellByIdAsync(int id) {
            return base.Channel.GetWellByIdAsync(id);
        }
        
        public string GetItemsPath(int id, string type) {
            return base.Channel.GetItemsPath(id, type);
        }
        
        public System.Threading.Tasks.Task<string> GetItemsPathAsync(int id, string type) {
            return base.Channel.GetItemsPathAsync(id, type);
        }
        
        public byte[] GetDocumentByid(int id, string type) {
            return base.Channel.GetDocumentByid(id, type);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetDocumentByidAsync(int id, string type) {
            return base.Channel.GetDocumentByidAsync(id, type);
        }
        
        public BLL.Contract.DTOModel.DocumentsDTO[] GetDocuments(int id, string type, int userId) {
            return base.Channel.GetDocuments(id, type, userId);
        }
        
        public System.Threading.Tasks.Task<BLL.Contract.DTOModel.DocumentsDTO[]> GetDocumentsAsync(int id, string type, int userId) {
            return base.Channel.GetDocumentsAsync(id, type, userId);
        }
        
        public string[] GetHints(int id, string template) {
            return base.Channel.GetHints(id, template);
        }
        
        public System.Threading.Tasks.Task<string[]> GetHintsAsync(int id, string template) {
            return base.Channel.GetHintsAsync(id, template);
        }
        
        public void AddFile(string shortName, int authorId, string version, byte[] bytes, int sectorId, bool isPrivate, bool canBeEdited, string type) {
            base.Channel.AddFile(shortName, authorId, version, bytes, sectorId, isPrivate, canBeEdited, type);
        }
        
        public System.Threading.Tasks.Task AddFileAsync(string shortName, int authorId, string version, byte[] bytes, int sectorId, bool isPrivate, bool canBeEdited, string type) {
            return base.Channel.AddFileAsync(shortName, authorId, version, bytes, sectorId, isPrivate, canBeEdited, type);
        }
        
        public void EditDocument(BLL.Contract.DTOModel.DocumentsDTO doc, string type) {
            base.Channel.EditDocument(doc, type);
        }
        
        public System.Threading.Tasks.Task EditDocumentAsync(BLL.Contract.DTOModel.DocumentsDTO doc, string type) {
            return base.Channel.EditDocumentAsync(doc, type);
        }
        
        public string GetAuthor(int id) {
            return base.Channel.GetAuthor(id);
        }
        
        public System.Threading.Tasks.Task<string> GetAuthorAsync(int id) {
            return base.Channel.GetAuthorAsync(id);
        }
        
        public void DeleteFile(int id, string type) {
            base.Channel.DeleteFile(id, type);
        }
        
        public System.Threading.Tasks.Task DeleteFileAsync(int id, string type) {
            return base.Channel.DeleteFileAsync(id, type);
        }
        
        public void SetNewDocData(BLL.Contract.DTOModel.DocumentsDTO doc, string type, byte[] data) {
            base.Channel.SetNewDocData(doc, type, data);
        }
        
        public System.Threading.Tasks.Task SetNewDocDataAsync(BLL.Contract.DTOModel.DocumentsDTO doc, string type, byte[] data) {
            return base.Channel.SetNewDocDataAsync(doc, type, data);
        }
        
        public bool IsAdmin(int id) {
            return base.Channel.IsAdmin(id);
        }
        
        public System.Threading.Tasks.Task<bool> IsAdminAsync(int id) {
            return base.Channel.IsAdminAsync(id);
        }
        
        public bool UserCanEditData(int id) {
            return base.Channel.UserCanEditData(id);
        }
        
        public System.Threading.Tasks.Task<bool> UserCanEditDataAsync(int id) {
            return base.Channel.UserCanEditDataAsync(id);
        }
        
        public BLL.Contract.DTOModel.FoundDocumentsDto[] FoundDocs(int userId, string template) {
            return base.Channel.FoundDocs(userId, template);
        }
        
        public System.Threading.Tasks.Task<BLL.Contract.DTOModel.FoundDocumentsDto[]> FoundDocsAsync(int userId, string template) {
            return base.Channel.FoundDocsAsync(userId, template);
        }
    }
}
