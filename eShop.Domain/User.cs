﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Domain
{
   public class User
    {
        public int Id { get; set; }
        public int Razryad { get; set; }
        public List<TV> TVs { get; set; }
    }
}
