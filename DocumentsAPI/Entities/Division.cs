using DocumentsAPI.Entities.BaseClasses;
using System.ComponentModel.DataAnnotations;

namespace DocumentsAPI.Entities
{
    public class Division : IsActiveIntKeyEntityBase
    {
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
