using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Code_Fidus_CsharpAPI.Models
{
    public class profiles : BaseEntity
    {
        [Key]
        public int profile_id { get { return id; } set { id = value; } }
        [ForeignKey("accounts.account_id")]
        public int account_id { get; set; }
        public accounts account { get; set; }
        [Required]
        public string firstname { get; set; }
        public string secondname { get; set; }
        [Required]
        public string lastname { get; set; }
        public string picture { get; set; }
        public string information { get; set; }
        public int worktitle { get; set; }
    }
}
