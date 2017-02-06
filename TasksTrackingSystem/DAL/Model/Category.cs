using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepo.Model
{
    public class CategoryDB: Entity
    {
        public string CategoryTitle { get; set; }
        public string Type { get; set; }
        public string Addition { get; set; }
        public virtual BindingList<ProjectDB> Projects { get; set; }
    }
}
