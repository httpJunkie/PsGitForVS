using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class Image
    {
        [Required]
        public int ImageId { get; set; }
        [StringLength(250), Column(TypeName = "varchar"), Display(Name = "Image URL"), DataType(DataType.ImageUrl)]
        public string Path { get; set; }
        [StringLength(100), Column(TypeName = "varchar"), Display(Name = "Image Name")]
        public string Name { get; set; }
        [StringLength(50), Column(TypeName = "varchar"), Display(Name = "Camera Angle")]
        public string Angle { get; set; }
        [StringLength(10), Column(TypeName = "varchar"), Display(Name = "Version")]
        public string Version { get; set; }
        public int RenderId { get; set; }

        public virtual Render Render { get; set; }
    }
}
