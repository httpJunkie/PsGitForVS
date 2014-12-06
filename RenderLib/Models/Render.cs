using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RenderLib.Models
{
    public class Render
    {
        public Render()
        {
            StageTypes = new List<StageType>();
            SeatingTypes = new List<SeatingType>();
            RenderYear = DateTime.UtcNow.Year;
            RenderMonth = DateTime.UtcNow.Month;
        }

        public int RenderId { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "varchar(Max)"), DataType(DataType.MultilineText)]
        public string Comment { get; set; }
        [Display(Name = "Job #")]
        public string JobId { get; set; }
        [Range(1, 12), Display(Name = "Render Month")]
        public int RenderMonth { get; set; }
        [Range(1970, 2099), Display(Name = "Render Year")]
        public int RenderYear { get; set; }
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Mapping { get; set; }
        public string Venue { get; set; }
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }

        //Many to One Relationships (Many Renders can have only one AttributeType)
        public int VenueTypeId { get; set; }
        public VenueType VenueType { get; set; }
        public int ScreenCountId { get; set; }
        public ScreenCount ScreenCount { get; set; }
        public int DominantColorId { get; set; }
        public DominantColor DominantColor { get; set; }


        public string UniqueString
        {
            get { return Title.Replace(" ", string.Empty) + RenderId + JobId; }
        }

        //Many to Many Collections Many Renders can have many AttributeTypes)
        public virtual ICollection<StageType> StageTypes { get; set; }
        public virtual ICollection<SeatingType> SeatingTypes { get; set; }
        public virtual ICollection<EventType> EventTypes { get; set; }
        public virtual ICollection<DisplayFormat> DisplayFormats { get; set; }
        public virtual ICollection<DisplayMethod> DisplayMethods { get; set; }
        public virtual ICollection<DrapeType> DrapeTypes { get; set; }
        public virtual ICollection<CeilingHeight> CeilingHeights { get; set; }
        public virtual ICollection<RiggingType> RiggingTypes { get; set; }
        public virtual ICollection<HardSet> HardSets { get; set; }
        public virtual ICollection<SoftSet> SoftSets { get; set; }
        public virtual ICollection<BackDrop> BackDrops { get; set; }

        //One to Many Collections (One Render can have many Images or many Comments)
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


        //Every Render needs one image that represents it
        [Display(Name = "Default Image")]
        public int DefaultImageId { get; set; }
    }
}