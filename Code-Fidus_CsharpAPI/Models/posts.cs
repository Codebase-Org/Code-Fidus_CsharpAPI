using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Fidus_CsharpAPI.Models
{
    public class posts : BaseEntity
    {
        [Key]
        public int post_id { get { return id; } set { id = value; } }
        [ForeignKey("categories.category_id")]
        public int category_id { get; set; }
        [ForeignKey("accounts.account_id")]
        public int account_id { get; set; }
        [ForeignKey("post_types.post_type_id")]
        public int post_type_id { get; set; }
        [Required]
        public string post_headline { get; set; }
        [Required]
        public string post_content { get; set; }
        [Required]
        public DateTime post_time { get; set; }
        public DateTime post_update { get; set; }
        public int post_views { get; set; }
    }
}
