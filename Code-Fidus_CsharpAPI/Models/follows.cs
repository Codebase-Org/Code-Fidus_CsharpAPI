using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Fidus_CsharpAPI.Models
{
    public class follows : BaseEntity
    {
        [Key]
        public int follow_id { get { return id; } set { id = value; } }
        [ForeignKey("accounts.account_id")]
        public int account_id { get; set; }
        [ForeignKey("category.category_id")]
        public int category_id { get; set; }
    }
}
