using System.ComponentModel.DataAnnotations.Schema;

namespace BoxManager.Model
{
    [Table("box_dimension")]
    public class Box_Dimension : BasicId
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double Depth { get; set; }
    }
}
