using System.ComponentModel.DataAnnotations;

namespace DocumentsAPI.Entities.BaseClasses
{
    public class IsActiveGuidKeyEntityBase : IsActiveEntityBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}
