using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class CeilingHeight
    {
        public int CeilingHeightId { get; set; }
        public string CeilingHeightName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
