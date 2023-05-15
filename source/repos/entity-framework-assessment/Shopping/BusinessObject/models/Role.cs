﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.BusinessObject.models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? DateCreated { get; set; }
        public bool IsActive { get; set; }


    }
}
