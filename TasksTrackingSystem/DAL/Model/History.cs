using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepo.Model
{
    public class HistoryDB: Entity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusDB Status { get; set; }
        public virtual UserDB AssignedUser { get; set; }
        public virtual TaskDB Task { get; set; }
        public string Note { get; set; }
    }
}
