using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models
{
    [Table("STATE_MASTER")]
    public class StateMaster
    {
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string? StateName { get; set; }
        public int StateCode { get; set; }
        public string? StateStatus { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedOn { get; set; }
    }
}
