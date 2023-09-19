using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Code_Fidus_CsharpAPI.Models
{
    public class post_types : BaseEntity
    {
        [Key]
        public int post_type_id { get { return id; } set { id = value; } }
        [Required]
        public string post_type_title { get; set; }
    }
}
