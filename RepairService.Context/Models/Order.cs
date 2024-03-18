using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairService.Context.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public int ClientId { get; set; }
        public User Client { get; set; }


        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

        public int BrokenTypeId { get; set; }
        public BrokenType BrokenType { get; set; }

        public string Description { get; set; } = null;

        [Required]
        public string Priority { get; set; }

        public StatusType Status { get; set; } = StatusType.notComplete;

        public ICollection<User> Workers { get; set; }

        public ICollection<Report> Reports { get; set; }

        public Order()
        {
            Workers = new HashSet<User>();
            Reports = new HashSet<Report>();
        }

    }
}
