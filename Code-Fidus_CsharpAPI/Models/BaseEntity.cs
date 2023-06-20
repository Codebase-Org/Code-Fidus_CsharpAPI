using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Fidus_CsharpAPI.Models
{
    public class BaseEntity
    {
        [NotMapped] // Betyder at attributten skal ekskluderes fra databasen
                    // der findes noget JsonIgnore data anotering.
        // Id bliver omdøbt i hvert tabel, ved at de specifikke id'er bliver sat lig med denne id. Das good sh!t
        public int id { get; set; }
    }
}
