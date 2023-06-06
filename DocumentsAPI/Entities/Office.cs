using DocumentsAPI.Entities.BaseClasses;
using System.ComponentModel.DataAnnotations;

namespace DocumentsAPI.Entities
{
    public class Office : IsActiveIntKeyEntityBase
    {
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
