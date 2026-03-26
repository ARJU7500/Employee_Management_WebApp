using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("PERMISSION_MASTER")]
    public class PermissionMaster
    {
        [Key]
        public int PermissionId { get; set; }
        public string? PermissionName { get; set; }
        public int RoleId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DeptId { get; set; }
        public int DeginationId { get; set; }
        public string? PermissionStatus { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
    }
}
