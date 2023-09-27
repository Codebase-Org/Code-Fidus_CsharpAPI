using System.ComponentModel.DataAnnotations;

namespace CodebaseCAPI.Models
{
    public class education : BaseEntity
    {
        [Key]
        public int education_id { get { return id; } set { id = value; } }
        [Required]
        public string education_title { get; set; }
    }
}
