using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class BackDrop
    {
        public int BackDropId { get; set; }
        public string BackDropName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
