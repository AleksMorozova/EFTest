﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepo.Model
{
    public class ProjectDB: Entity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Number { get; set; }
        public string Description { get; set; }
        public virtual BindingList<UserDB> Users { get; set; }
        public virtual BindingList<TaskDB> Tasks { get; set; }
        public virtual BindingList<CategoryDB> Projects { get; set; }
    }
}
