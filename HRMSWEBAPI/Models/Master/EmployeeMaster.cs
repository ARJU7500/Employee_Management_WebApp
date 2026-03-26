using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("EMPLOYEE_MASTER")]
    public class EmployeeMaster
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeCode { get; set; }
        public string? EmailId { get; set; }
        public string? Password { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int DeginationId { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
        public string? PhoneNo { get; set; }
        public string? FullName { get; set; }
        public string? CurrentAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public string? PanNo { get; set; }
        public string? AdharNo { get; set; }
        public string? AcccountNo { get; set; }
        public string? ImageUrl { get; set; }
        public string? JoiningDate { get; set; }
        public string? EndDate { get; set; }
        public int DocumentId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int PinCode { get; set; }
        public string? EmpStatus { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
        // Navigation
        public DeginationMaster? DesignationMaster { get; set; }
        public ICollection<DocumentMaster>? Documents { get; set; }
    }
}
