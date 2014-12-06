using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class ScreenCount
    {
        public int ScreenCountId { get; set; }
        public string ScreenCountName { get; set; }
        public virtual List<Render> Renders { get; set; }
    }
}
