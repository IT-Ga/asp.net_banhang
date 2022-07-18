using SV18T1021002.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021002.WEB.Models
{
    public class ProductBasePaginationResult : BasePaginationResult
    {
        /// <summary>
        /// Danh sách cho loại hàng
        /// </summary>
        /// 
        public List<Product> Data { get; set; }
    }
}