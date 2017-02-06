using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepo.Model
{
    public class UserDB: Entity
    {
        [Required]
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<ProjectDB> Projects { get; set; }
        public virtual List<RoleDB> Roles { get; set; }
    }
}
