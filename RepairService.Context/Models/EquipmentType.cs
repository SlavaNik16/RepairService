using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepairService.Context.Models
{
    public class EquipmentType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public ICollection<Equipment> Equipments { get; set; }

        public EquipmentType()
        {
            Equipments = new HashSet<Equipment>();
        }
    }
}