using System.ComponentModel.DataAnnotations;

namespace BoxManager.Model
{
    public class Box : BasicId
    {
        public int? Dimension_Id { get; set; }

        public int? Main_Box_Id { get; set; }

        [StringLength(25)]
        public string Label { get; set; }

        public double? Fullness_Percentage { get; set; }

        public double? Maximum_Weight {get; set; }

        public override string ToString() => $"Box {Id} with label '{Label}'";
    }
}
