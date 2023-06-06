using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Reflection.Metadata;

namespace DocumentsAPI.DTOs
{
    public class DocumentDTOBase
    {
        public string FileName { get; set; }

        public string FileType { get; set; }

        public int DivisionId { get; set; }

        public int DepartmentId { get; set; }

        public int OfficeId { get; set; }

        public int FolderId { get; set; }

        public Guid ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }
    }

    public class DocumentDTO : DocumentDTOBase
    {

    }

    public class DocumentDTOWithId : DocumentDTOBase
    {
        public Guid Id { get; set; }
    }
}
