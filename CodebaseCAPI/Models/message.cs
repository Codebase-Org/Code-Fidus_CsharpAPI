using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodebaseCAPI.Models
{
    public class message : BaseEntity
    {
        [Key]
        public int message_id { get { return id; } set { id = value; } }
        [ForeignKey("accounts.account_id")]
        public int from_account_id { get; set; }
        [ForeignKey("accounts.account_id")]
        public int to_account_id { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        public string content { get; set; }
        [Required]
        public DateTime send_date { get; set; }
        [Required]
        public bool readornot { get; set; }
    }
}
