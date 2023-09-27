using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodebaseCAPI.Models
{
    public class post_type : BaseEntity
    {
        [Key]
        public int post_type_id { get { return id; } set { id = value; } }
        [Required]
        public string post_type_title { get; set; }
    }
}
