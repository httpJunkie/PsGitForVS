using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class SoftSet
    {
        public int SoftSetId { get; set; }
        public string SoftSetName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
