using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("COMPANY_MASTER")]
    public class CompanyMaster
    {
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyCode { get; set; }
        public string? Address { get; set; }
        public string? PhoneNo { get; set; }
        public string? OpEmailId { get; set; }
        public string? CommEmailId { get; set; }
        public string? GstIn { get; set; }
        public string? PanNo { get; set; }
        public string? LogoUrl { get; set; }
        public string? CompanyStatus { get; set; }
        public int DocumentId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int PinCode { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
    }
}
