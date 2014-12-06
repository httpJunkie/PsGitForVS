using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class DrapeType
    {
        public int DrapeTypeId { get; set; }
        public string DrapeTypeName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
