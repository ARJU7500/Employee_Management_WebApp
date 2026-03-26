using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("BRANCH_MASTER")]
    public class BranchMaster
    {
        [Key]
        public int BranchId { get; set; }
        public int CompanyId { get; set; }
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
        public string? Address { get; set; }
        public string? PhoneNo { get; set; }
        public string? AlternetNo { get; set; }
        public string? OpEmailId { get; set; }
        public string? CommEmailId { get; set; }
        public string? GstIn { get; set; }
        public string? PanNo { get; set; }
        public string? LogoUrl { get; set; }
        public string? BranchStatus { get; set; }
        public int DocumentId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int PinCode { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
        // Navigation
        public CompanyMaster? CompanyMaster { get; set; }
        public CountryMaster? CountryMaster { get; set; }
        public StateMaster? StateMaster { get; set; }
        public CityMaster? CityMaster { get; set; }

        public ICollection<DepartmentMaster>? Departments { get; set; }
        public ICollection<DocumentMaster>? Documents { get; set; }
    
    }
}
