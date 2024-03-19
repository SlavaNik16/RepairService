using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairService.Context.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        [Required]
        public decimal Price { get; set; } = 0;

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public string Reason { get; set; }

        public ICollection<SparesCount> SparesCounts { get; set; }

        public Report()
        {
            SparesCounts = new HashSet<SparesCount>();
        }

    }
}
