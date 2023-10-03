using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodebaseCAPI.Models
{
    public class account : BaseEntity
    {        
        [Key]
        public int account_id { get { return id; } set { id = value; } }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string email { get; set; }
        [ForeignKey("role.role_id"), Required]
        public int role_id { get; set; }
        [ForeignKey("account.account_id")]
        public int? instructor_id { get; set; }
        [Required]
        public int onlineStatus { get; set; }
        [Required]
        public DateOnly created_date { get; set; }
        public DateOnly? end_date { get; set; }
    }
}
