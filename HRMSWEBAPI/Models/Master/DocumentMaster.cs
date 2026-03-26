using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("DOCUMENT_MASTER")]
    public class DocumentMaster
    {
        [Key]
        public int DocumentId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int EmployeeId { get; set; }
        public string? DocumentName { get; set; }
        public string? DocumentUrl { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
        // Navigation
        public CompanyMaster? CompanyMaster { get; set; }
        public BranchMaster? BranchMaster { get; set; }
        public EmployeeMaster? EmployeeMaster { get; set; }
    }
}
