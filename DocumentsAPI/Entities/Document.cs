using DocumentsAPI.Entities.BaseClasses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DocumentsAPI.Entities
{
    public class Document : IsActiveGuidKeyEntityBase
    {
        [MaxLength(30)]
        public string FileName { get; set; }

        [MaxLength(10)]
        public string FileType { get; set; }

        public int DivisionId { get; set; }

        [ForeignKey(nameof(DivisionId))]
        public Division Division { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; }

        public int OfficeId { get; set; }

        [ForeignKey(nameof(OfficeId))]
        public Office Office { get; set; }

        public int FolderId { get; set; }

        [ForeignKey(nameof(FolderId))]
        public Folder Folder { get; set; }

        public Guid ModifiedBy { get; set; }

        [ForeignKey(nameof(ModifiedBy))]
        public User User { get; set; }

        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Corresponding reference for the document in Azure File Storage.
        /// </summary>
        public string AzureStorageReference { get; set; }
    }
}
