using SV18T1021002.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SV18T1021002.WEB.Models
{
    /// <summary>
    /// Kết quả tìm kiếm,phân trang cho nhân viên
    /// </summary>

    public class EmployeeBasePaginationResult :BasePaginationResult
    {
        /// <summary>
        /// Danh sách cho nhân viên
        /// </summary>
        /// 
        public List<Employee> Data { get; set; }
    }
}