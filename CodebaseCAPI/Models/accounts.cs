using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodebaseCAPI.Models
{
    public class accounts : BaseEntity
    {        
        [Key]
        public int account_id { get { return id; } set { id = value; } }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string email { get; set; }

        [ForeignKey("roles.role_id")]
        public int role_id { get; set; }

        [Required]
        public DateTime created_date { get; set; }
        [Required]
        public DateTime end_date { get; set; }
    }
}
