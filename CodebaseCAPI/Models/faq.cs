using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodebaseCAPI.Models
{
    public class faq : BaseEntity
    {
        [Key]
        public int faq_id { get { return id; } set { id = value; } }
        [Required]
        public string faq_title { get; set; }
        [Required]
        public string faq_content { get; set; }
        [Required]
        public DateTime faq_time { get; set; }
    }
}
