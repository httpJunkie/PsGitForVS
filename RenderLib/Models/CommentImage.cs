using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class CommentImage
    {
        [Required]
        public int CommentImageId { get; set; }
        [StringLength(250), Column(TypeName = "varchar"), Display(Name = "Image URL"), DataType(DataType.ImageUrl)]
        public string Path { get; set; }
        [StringLength(100), Column(TypeName = "varchar"), Display(Name = "Title")]
        public string Name { get; set; }

        //Many to one Relationship (Many CommentImages can be associated to only one Comment)
        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }

        //*Renders will be able to see all CommentImages associated with itself
        public int RenderId { get; set; }
    }
}
