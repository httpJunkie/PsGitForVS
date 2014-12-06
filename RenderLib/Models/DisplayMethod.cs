using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class DisplayMethod
    {
        public int DisplayMethodId { get; set; }
        public string DisplayMethodName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
