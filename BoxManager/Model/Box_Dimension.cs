using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxManager.Model
{
    public class Box_Dimension : BasicId
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double Depth { get; set; }
    }
}
