using System.ComponentModel.DataAnnotations;

namespace DocumentsAPI.Entities.BaseClasses
{
    public class IsActiveIntKeyEntityBase : IsActiveEntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
