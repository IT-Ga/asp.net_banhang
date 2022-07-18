using SV18T1021002.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021002.WEB.Models
{
    /// <summary>
    /// Kết quả tìm kiếm,phân trang cho khách hàng
    /// </summary>
    public class CustomerBasePaginationResult : BasePaginationResult
    {
        /// <summary>
        /// Danh sách cho khách hàng
        /// </summary>
        /// 
        public List<Customer> Data { get; set; }
    }
}