using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("CITY_MASTER")]
    public class CityMaster
    {
        [Key]
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string? CityName { get; set; }
        public int CityCode { get; set; }
        public string? CityStatus { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
        // Navigation Properties
        public CountryMaster? CountryMaster { get; set; }
        public StateMaster? StateMaster { get; set; }
    }
}
