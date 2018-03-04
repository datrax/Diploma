using System;

namespace BLL.Contract.DTOModel
{
    public class FoundDocumentsDto
    {
        public int id { get; set; }   
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }      
        public string AuthorName { get; set; }           
        public DateTime? dateTime { get; set; }     
        public string LastChangeUserName { get; set; }
        public string Version { get; set; }
    }
}
