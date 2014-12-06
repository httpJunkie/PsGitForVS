using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class VenueType
    {
        public int VenueTypeId { get; set; }
        public string VenueTypeName { get; set; }
        public virtual List<Render> Renders { get; set; }
    }
}
