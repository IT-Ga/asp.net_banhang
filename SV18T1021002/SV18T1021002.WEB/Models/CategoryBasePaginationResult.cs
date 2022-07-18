
using SV18T1021002.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021002.WEB.Models
{
    /// <summary>
    /// Kết quả tìm kiếm,phân trang cho loại hàng
    /// </summary>
    public class CategoryBasePaginationResult : BasePaginationResult
    {
        /// <summary>
        /// Danh sách cho loại hàng
        /// </summary>
        /// 
        public List<Category> Data { get; set; }
    }
}