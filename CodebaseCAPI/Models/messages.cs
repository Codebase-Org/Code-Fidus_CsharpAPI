using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Fidus_CsharpAPI.Models
{
    public class messages : BaseEntity
    {
        [Key]
        public int message_id { get { return id; } set { id = value; } }
        [ForeignKey("accounts.account_id")]
        public int from_account_id { get; set; }
        [ForeignKey("accounts.account_id")]
        public int to_account_id { get; set; }
        [Required]
        public string subject { get; set; }
        public string content { get; set; }
        public DateTime send_date { get; set; }
        public bool readornot { get; set; }
    }
}
