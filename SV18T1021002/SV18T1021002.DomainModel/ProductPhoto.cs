﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV18T1021002.DomainModel
{
   public  class ProductPhoto
    {
        public int PhotoID { get; set; }
        public int ProductID { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
    }
}
