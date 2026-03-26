using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("STATE_MASTER")]
    public class StateMaster
    {
        [Key]
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string? StateName { get; set; }
        public int StateCode { get; set; }
        public string? StateStatus { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
        public CountryMaster? CountryMaster { get; set; }
        // Navigation Property (1 State → Many Cities)
        public ICollection<CityMaster>? Cities { get; set; }
    }
}
