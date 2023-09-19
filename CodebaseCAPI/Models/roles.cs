using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Fidus_CsharpAPI.Models
{
    public class roles : BaseEntity
    {
        [Key]
        public int role_id { get { return id; } set { id = value; } } 

        [Required]
        public string role_name { get; set; }
        public DateTime created_at { get; set; }
    }
}
