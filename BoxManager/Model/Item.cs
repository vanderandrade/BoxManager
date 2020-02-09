using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoxManager.Model
{
    [Table("item")]
    public class Item : BasicId
    {
        public int Box_Id { get; set; }

        [StringLength(40)]
        public string Description { get; set; }

        public double? Weight { get; set; }
    }
}
