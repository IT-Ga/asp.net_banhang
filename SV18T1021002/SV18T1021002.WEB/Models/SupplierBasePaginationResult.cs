using SV18T1021002.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021002.WEB.Models

{
    /// <summary>
    /// Kết quả tìm kiếm,phân trang cho nhà cung cấp
    /// </summary>
    public class SupplierBasePaginationResult : BasePaginationResult
    {
        /// <summary>
        /// Danh sách cho nhà cung cấp
        /// </summary>
        /// 
        public List<Supplier> Data { get; set; }
    }
}