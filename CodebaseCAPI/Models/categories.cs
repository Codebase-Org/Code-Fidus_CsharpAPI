using System.ComponentModel.DataAnnotations;

namespace Code_Fidus_CsharpAPI.Models
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
