using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class StageType
    {
        public int StageTypeId { get; set; }
        public string StageTypeName { get; set; }
        public ICollection<Render> Renders { get; set; }
    }
}
