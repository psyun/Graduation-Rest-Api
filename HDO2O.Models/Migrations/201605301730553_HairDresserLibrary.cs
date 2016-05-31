namespace HDO2O.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HairDresserLibrary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyHairDressLibraries",
                c => new
                    {
                        MyHairDressLibraryId = c.Guid(nullable: false),
                        HairDresserId = c.String(maxLength: 128),
                        HairDressLibraryId = c.Guid(nullable: false),
                        ForkType = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MyHairDressLibraryId)
                .ForeignKey("dbo.AspNetUsers", t => t.HairDresserId)
                .ForeignKey("dbo.HairDressLibraries", t => t.HairDressLibraryId, cascadeDelete: true)
                .Index(t => t.HairDresserId)
                .Index(t => t.HairDressLibraryId);
            
            CreateTable(
                "dbo.HairDressLibraries",
                c => new
                    {
                        HairDressLibraryId = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        ThumbnailImage = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.HairDressLibraryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MyHairDressLibraries", "HairDressLibraryId", "dbo.HairDressLibraries");
            DropForeignKey("dbo.MyHairDressLibraries", "HairDresserId", "dbo.AspNetUsers");
            DropIndex("dbo.MyHairDressLibraries", new[] { "HairDressLibraryId" });
            DropIndex("dbo.MyHairDressLibraries", new[] { "HairDresserId" });
            DropTable("dbo.HairDressLibraries");
            DropTable("dbo.MyHairDressLibraries");
        }
    }
}
