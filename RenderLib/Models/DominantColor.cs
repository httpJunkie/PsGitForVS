using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class DominantColor
    {
        public int DominantColorId { get; set; }
        public string DominantColorName { get; set; }
        public virtual List<Render> Renders { get; set; }
    }
}
