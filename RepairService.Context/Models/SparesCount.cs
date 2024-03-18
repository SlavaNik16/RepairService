using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace RepairService.Context.Models
{
    public class SparesCount
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Count { get; set; }

        public int SparesTypeId { get; set; }
        public SparesType SparesType { get; set; }

        public ICollection<Report> Reports { get; set; }

        public SparesCount()
        {
            Reports = new HashSet<Report>();
        }
    }
}
