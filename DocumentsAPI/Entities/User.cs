using DocumentsAPI.Entities.BaseClasses;
using System.ComponentModel.DataAnnotations;

namespace DocumentsAPI.Entities
{
    public class User : IsActiveGuidKeyEntityBase
    {
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
    