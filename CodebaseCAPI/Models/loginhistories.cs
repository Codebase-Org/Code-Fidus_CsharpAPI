using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Code_Fidus_CsharpAPI.Models
{
    public class loginhistories : BaseEntity
    {
        [Key]
        public int follow_id { get { return id; } set { id = value; } }
        [ForeignKey("accounts.account_id")]
        public int account_id { get; set; }
        [Required]
        public DateTime login_time { get; set; }
        public DateTime logout_time { get; set; }
    }
}
