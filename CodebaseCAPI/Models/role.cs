using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodebaseCAPI.Models
{
    public class role : BaseEntity
    {
        [Key]
        public int role_id { get { return id; } set { id = value; } } 

        [Required]
        public string role_name { get; set; }
        [Required]
        public DateTime created_at { get; set; }
    }
}
