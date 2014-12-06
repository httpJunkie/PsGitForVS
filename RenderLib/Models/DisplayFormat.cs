using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class DisplayFormat
    {
        public int DisplayFormatId { get; set; }
        public string DisplayFormatName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
