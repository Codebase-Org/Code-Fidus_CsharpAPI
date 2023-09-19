using System.ComponentModel.DataAnnotations;

namespace CodebaseCAPI.Models
{
    public class categories : BaseEntity
    {
        [Key]
        public int category_id { get { return id; } set { id = value; } }
        [Required]
        public string catname { get; set; }
        public string picture { get; set; }
    }
}
