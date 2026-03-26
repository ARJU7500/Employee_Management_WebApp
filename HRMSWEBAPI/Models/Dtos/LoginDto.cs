using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSWEBAPI.Models.Dtos
{
    [Table("LOGIN_DATA")]
    public class LoginDto
    {
        [Key]
        public int loginId {get;set;}
        public string emailId { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string macAddress { get; set; } = string.Empty;
        public string loginTime { get; set; } = string.Empty;
        public string logOutTime { get; set; } = string.Empty;
        public string loginDate { get; set; } = string.Empty;

    }
}
