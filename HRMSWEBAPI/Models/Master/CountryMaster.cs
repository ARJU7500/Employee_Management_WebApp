using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("COUNTRY_MASTER")]
    public class CountryMaster
    {
        [Key]
        public int CountryId { get; set; }
        public string? CountryName { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryStatus { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
        // Navigation Property (1 Country → Many States)
        public ICollection<StateMaster>? States { get; set; }
    }
}
