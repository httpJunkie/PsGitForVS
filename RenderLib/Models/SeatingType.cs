using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class SeatingType
    {
        public int SeatingTypeId { get; set; }
        public string SeatingTypeName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
