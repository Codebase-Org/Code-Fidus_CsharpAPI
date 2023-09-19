using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodebaseCAPI.Models
{
    public class faqs : BaseEntity
    {
        [Key]
        public int follow_id { get { return id; } set { id = value; } }
        [ForeignKey("accounts.account_id")]
        public int account_id { get; set; }
        [Required]
        public string faq_title { get; set; }
        [Required]
        public string faq_content { get; set; }
        [Required]
        public DateTime faq_created_date { get; set; }
        public DateTime faq_updated_date { get; set; }
    }
}
