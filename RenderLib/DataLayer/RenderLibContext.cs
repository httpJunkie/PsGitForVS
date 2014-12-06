using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RenderLib.Models;

namespace RenderLib.DataLayer
{
    public class RenderLibContext : DbContext
    {
                public RenderLibContext() : base("name=DefaultConnection")
        {            
        }

                public DbSet<Render> Renders { get; set; }
                //Image class not needed here, already added to Db  
                //because of it's relationship with Render (public class).

                public DbSet<EventType> EventTypes { get; set; }
                public DbSet<VenueType> VenueTypes { get; set; }
                public DbSet<DisplayFormat> DisplayFormats { get; set; }
                public DbSet<DisplayMethod> DisplayMethods { get; set; }
                public DbSet<DominantColor> DominantColors { get; set; }
                public DbSet<DrapeType> DrapeTypes { get; set; }
                public DbSet<CeilingHeight> CeilingHeights { get; set; }
                public DbSet<RiggingType> RiggingTypes { get; set; }
                public DbSet<HardSet> HardSets { get; set; }
                public DbSet<SoftSet> SoftSets { get; set; }
                public DbSet<BackDrop> BackDrops { get; set; }
                public DbSet<SeatingType> SeatingTypes { get; set; }
                public DbSet<ScreenCount> ScreenCounts { get; set; }
                public DbSet<StageType> StageTypes { get; set; }

                public DbSet<Comment> Comments { get; set; }
                public DbSet<Image> Images { get; set; }
                public DbSet<CommentImage> CommentImage { get; set; }




                protected override void OnModelCreating(DbModelBuilder modelBuilder)
                {
                    //modelBuilder.Configurations.Add(new RenderConfiguration());

                    //modelBuilder.Configurations.Add(new EventTypeConfiguration());
                    //modelBuilder.Configurations.Add(new VenueTypeConfiguration());
                    //modelBuilder.Configurations.Add(new DisplayFormatConfiguration());
                    //modelBuilder.Configurations.Add(new DisplayMethodConfiguration());
                    //modelBuilder.Configurations.Add(new DominantColorConfiguration());
                    //modelBuilder.Configurations.Add(new DrapeTypeConfiguration());
                    //modelBuilder.Configurations.Add(new CeilingHeightConfiguration());
                    //modelBuilder.Configurations.Add(new RiggingTypeConfiguration());
                    //modelBuilder.Configurations.Add(new HardSetConfiguration());
                    //modelBuilder.Configurations.Add(new SoftSetConfiguration());
                    //modelBuilder.Configurations.Add(new BackDropConfiguration());
                    //modelBuilder.Configurations.Add(new ScreenCountConfiguration());

                    base.OnModelCreating(modelBuilder);


                    modelBuilder.Entity<StageType>()
                        .HasMany(st => st.Renders)
                        .WithMany(st => st.StageTypes)
                        .Map(m =>
                        {
                            m.ToTable("StageTypeRender");
                            m.MapLeftKey("StageTypeId");
                            m.MapRightKey("RenderId");
                        });

                    modelBuilder.Entity<SeatingType>()
                        .HasMany(st => st.Renders)
                        .WithMany(st => st.SeatingTypes)
                        .Map(m =>
                        {
                            m.ToTable("SeatingTypeRender");
                            m.MapLeftKey("SeatingTypeId");
                            m.MapRightKey("RenderId");
                        });

                    modelBuilder.Entity<EventType>()
                        .HasMany(et => et.Renders)
                        .WithMany(et => et.EventTypes)
                        .Map(m =>
                        {
                            m.ToTable("EventTypeRender");
                            m.MapLeftKey("EventTypeId");
                            m.MapRightKey("RenderId");
                        });

                    modelBuilder.Entity<DisplayFormat>()
                        .HasMany(df => df.Renders)
                        .WithMany(df => df.DisplayFormats)
                        .Map(m =>
                        {
                            m.ToTable("DisplayFormatRender");
                            m.MapLeftKey("DisplayFormatId");
                            m.MapRightKey("RenderId");
                        });

                    modelBuilder.Entity<DisplayMethod>()
                        .HasMany(dm => dm.Renders)
                        .WithMany(dm => dm.DisplayMethods)
                        .Map(m =>
                        {
                            m.ToTable("DisplayMethodRender");
                            m.MapLeftKey("DisplayMethodId");
                            m.MapRightKey("RenderId");
                        });

                    modelBuilder.Entity<DrapeType>()
                        .HasMany(dt => dt.Renders)
                        .WithMany(dt => dt.DrapeTypes)
                        .Map(m =>
                        {
                            m.ToTable("DrapeTypeRender");
                            m.MapLeftKey("DrapeTypeId");
                            m.MapRightKey("RenderId");
                        });

                    modelBuilder.Entity<CeilingHeight>()
                        .HasMany(ch => ch.Renders)
                        .WithMany(ch => ch.CeilingHeights)
                        .Map(m =>
                        {
                            m.ToTable("CeilingHeightRender");
                            m.MapLeftKey("CeilingHeightId");
                            m.MapRightKey("RenderId");
                        });

                    modelBuilder.Entity<RiggingType>()
                        .HasMany(rt => rt.Renders)
                        .WithMany(rt => rt.RiggingTypes)
                        .Map(m =>
                        {
                            m.ToTable("RiggingTypeRender");
                            m.MapLeftKey("RiggingTypeId");
                            m.MapRightKey("RenderId");
                        });

                    modelBuilder.Entity<HardSet>()
                        .HasMany(hs => hs.Renders)
                        .WithMany(hs => hs.HardSets)
                        .Map(m =>
                        {
                            m.ToTable("HardSetRender");
                            m.MapLeftKey("HardSetId");
                            m.MapRightKey("RenderId");
                        });

                    modelBuilder.Entity<SoftSet>()
                        .HasMany(ss => ss.Renders)
                        .WithMany(ss => ss.SoftSets)
                        .Map(m =>
                        {
                            m.ToTable("SoftSetRender");
                            m.MapLeftKey("SoftSetId");
                            m.MapRightKey("RenderId");
                        });

                    modelBuilder.Entity<BackDrop>()
                        .HasMany(ss => ss.Renders)
                        .WithMany(ss => ss.BackDrops)
                        .Map(m =>
                        {
                            m.ToTable("BackDropRender");
                            m.MapLeftKey("BackDropId");
                            m.MapRightKey("RenderId");
                        });
                }
    }

        
}