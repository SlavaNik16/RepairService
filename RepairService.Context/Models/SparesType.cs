using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepairService.Context.Models
{
    public class SparesType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public ICollection<SparesCount> SparesCounts { get; set; }

        public SparesType()
        {
            SparesCounts = new HashSet<SparesCount>();
        }
    }
}