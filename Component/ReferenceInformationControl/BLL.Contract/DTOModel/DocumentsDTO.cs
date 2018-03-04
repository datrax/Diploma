using System;

namespace BLL.Contract.DTOModel
{
    public class DocumentsDTO
    {
        public int id { get; set; }

        public int ParentId { get; set; }


        public string Name { get; set; }

        //        public byte[] Data { get; set; }

        public int? Author { get; set; }
        public string AuthorName { get; set; }

        public bool BeingEdited { get; set; }

        public bool UsersCanEdit { get; set; }

        public bool IsPrivate { get; set; }
        public DateTime? dateTime { get; set; }
        public int? LastChangeUser { get; set; }
        public int? UserThatEdits { get; set; }
        public string LastChangeUserName { get; set; }
        public string Version { get; set; }
    }
}
