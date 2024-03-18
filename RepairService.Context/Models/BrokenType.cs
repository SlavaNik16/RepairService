using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairService.Context.Models
{
    public class BrokenType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public ICollection<Order> Orders { get; set; }

        public BrokenType()
        {
            Orders = new HashSet<Order>();
        }
    }
}
