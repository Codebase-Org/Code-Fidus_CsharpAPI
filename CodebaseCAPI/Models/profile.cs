using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodebaseCAPI.Models
{
    public class profile : BaseEntity
    {
        [Key]
        public int profile_id { get { return id; } set { id = value; } }
        [ForeignKey("accounts.account_id")]
        public int account_id { get; set; }
        [Required]
        public string firstname { get; set; }
        public string secondname { get; set; }
        [Required]
        public string lastname { get; set; }
        public string picture { get; set; }
        [ForeignKey("educations.education_id")]
        public int education_id { get; set; }
        public string internship { get; set; }
        public string information { get; set; }
        public int worktitle { get; set; }
        public string location { get; set; }
        public DateTime birthday { get; set; }
    }
}
