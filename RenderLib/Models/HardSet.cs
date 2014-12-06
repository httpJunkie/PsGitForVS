using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class HardSet
    {
        public int HardSetId { get; set; }
        public string HardSetName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
