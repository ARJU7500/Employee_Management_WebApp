using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("DEGINATION_MASTER")]
    public class DeginationMaster
    {
        [Key]
        public int DeginationId { get; set; }
        public string? DeginationName { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DeptId { get; set; }
        public string? DeginationStatus { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
        // Navigation
        public DepartmentMaster? DepartmentMaster { get; set; }
        public ICollection<EmployeeMaster>? Employees { get; set; }
    }
}
