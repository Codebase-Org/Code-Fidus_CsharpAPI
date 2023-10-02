using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodebaseCAPI.Models
{
    public class login_history : BaseEntity
    {
        [Key]
        public int loginhist_id { get { return id; } set { id = value; } }
        [ForeignKey("account.account_id")]
        public int account_id { get; set; }
        [Required]
        public DateTime login_time { get; set; }
        public DateTime logout_time { get; set; }
    }
}
