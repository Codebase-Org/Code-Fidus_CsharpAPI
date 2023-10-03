using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodebaseCAPI.Models
{
    public class post : BaseEntity
    {
        [Key]
        public int post_id { get { return id; } set { id = value; } }
        [ForeignKey("category.category_id")]
        public int category_id { get; set; }
        [ForeignKey("account.account_id")]
        public int account_id { get; set; }
        [ForeignKey("post_type.post_type_id")]
        public int post_type_id { get; set; }
        [Required]
        public string post_headline { get; set; }
        [Required]
        public string post_content { get; set; }
        [Required]
        public DateTime post_time { get; set; }
        public DateTime? post_update { get; set; }
        public int post_views { get; set; } = 0;

        // Bruges til søgefunktion, hvor mange gange termer matcher i headline og content.
        [NotMapped]
        public int matchCount { get; set; } = 0;
    }
}
