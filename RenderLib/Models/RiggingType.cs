using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class RiggingType
    {
        public int RiggingTypeId { get; set; }
        public string RiggingTypeName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
