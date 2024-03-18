using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairService.Context.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Name { get; set; }
        public string Patronymic { get; set; } = null;

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        public RoleTypes RoleType { get; set; } = RoleTypes.User;

        public ICollection<Order> OrderClient { get; set; }
        public ICollection<Order> OrderWorkers { get; set; }

        public User()
        {
            OrderClient = new HashSet<Order>();
            OrderWorkers = new HashSet<Order>();
        }
    }
}
