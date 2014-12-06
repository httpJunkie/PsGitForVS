using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RenderLib.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [StringLength(40), Column(TypeName = "varchar"), Display(Name = "Full Name")]
        public string Name { get; set; }
        [StringLength(60), Column(TypeName = "varchar"), EmailAddress]
        public string Email { get; set; }
        [StringLength(40), Column(TypeName = "varchar")]
        public string Location { get; set; }

        [Column(TypeName = "varchar(Max)"), DataType(DataType.MultilineText), Display(Name = "User Comment")]
        public string UserComment { get; set; }
        [Display(Name = "Approve Comment")]
        public bool CommentApproved { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }

        [Display(Name = "Attached Render")]
        public int RenderId { get; set; }
        public virtual Render Render { get; set; }

        public string UniqueStringA
        {
            get { return Name.Replace(" ", string.Empty) + CommentId + "App"; }
        }
        public string UniqueStringD
        {
            get { return Name.Replace(" ", string.Empty) + CommentId + "Del"; }
        }
        public string UniqueStringU
        {
            get { return Name.Replace(" ", string.Empty) + CommentId + "Una"; }
        }

        //One to Many Collections (One Comment can have many CommentImages)
        public virtual ICollection<CommentImage> CommentImages { get; set; }
    }
}
