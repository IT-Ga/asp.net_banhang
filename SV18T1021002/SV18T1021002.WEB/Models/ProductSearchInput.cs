using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021002.WEB.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductSearchInput : PaginationSearchInput
    {
        public string SupplierName { get; set; }
        public string CategoryName { get; set; }
    }
}