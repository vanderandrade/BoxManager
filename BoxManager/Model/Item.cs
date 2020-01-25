using System.ComponentModel.DataAnnotations;

namespace BoxManager.Model
{
    public class Item : BasicId
    {
        public int Box_Id { get; set; }

        [StringLength(40)]
        public string Description { get; set; }

        public double? Weight { get; set; }
    }
}
