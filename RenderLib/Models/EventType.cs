using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class EventType
    {
        public int EventTypeId { get; set; }
        public string EventTypeName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
