using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodebaseCAPI.Models
{
    public class answars : BaseEntity
    {
        [Key]
        public int answar_id { get { return id; } set { id = value; } }
        [ForeignKey("posts.post_id")]
        public int post_id { get; set; }
        [ForeignKey("accounts.account_id")]
        public int account_id { get; set; }
        [Required]
        public DateTime answar_time { get; set; }
        [Required]
        public string answar_content { get; set; }
    }
}
