using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("ROLE_MASTER")]
    public class RoleMaster
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DeptId { get; set; }
        public int DeginationId { get; set; }
        public string? RoleStatus { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
    }
}
