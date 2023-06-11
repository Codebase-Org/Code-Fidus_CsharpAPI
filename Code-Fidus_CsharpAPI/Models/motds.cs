using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Code_Fidus_CsharpAPI.Models
{
    public class motds : BaseEntity
    {
        [Key]
        public int motd_id { get { return id; } set { id = value; } }
        [ForeignKey("accounts.account_id")]
        public int account_id { get; set; }
        public accounts account { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string context { get; set; }
        [Required]
        public DateTime motd_date { get; set; }
    }
}
