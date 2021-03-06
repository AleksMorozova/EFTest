﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepo.Model
{
    public class TaskDB: Entity
    {
        [Required]
        public string Number { get; set; }
        public string Specification { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime FinishDate { get; set; }
        public PriorityDB Priority { get; set; }
        public StatusDB Status { get; set; }
        public virtual ProjectDB Project { get; set; }
        public virtual UserDB CurrentUser { get; set; }
        public virtual UserDB Author { get; set; }
        public virtual CategoryDB Category { get; set; }
        public virtual List<HistoryDB> Tasks { get; set; }
    }
}
