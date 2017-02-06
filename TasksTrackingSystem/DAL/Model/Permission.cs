using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepo.Model
{
    public class PermissionDB :Entity
    {
        public string Title { get; set; }
        public PermissionTypeDB Type { get; set; }
        public virtual BindingList<RoleDB> Roles { get; set; }
    }
}
