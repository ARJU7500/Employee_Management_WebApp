using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("DEPARTMENT_MASTER")]
    public class DepartmentMaster
    {
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        public string? DeptCode { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public string? DeptLocation { get; set; }
        public string? DeptStatus { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
    }
}
