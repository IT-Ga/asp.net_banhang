using SV18T1021002.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021002.WEB.Models
{
    /// <summary>
    /// Kết quả tìm kiếm,phân trang cho người giao hàng
    /// </summary>

    public class ShipperBasePaginationResult : BasePaginationResult
    
    {
        /// <summary>
        /// Danh sách cho người giao hàng
        /// </summary>
        /// 
        public List<Shipper> Data { get; set; }
    }
}