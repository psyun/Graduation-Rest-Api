namespace HDO2O.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BarbershopHairDressers",
                c => new
                    {
                        BarbershopHairDresserId = c.Guid(nullable: false),
                        BarbershopId = c.Guid(nullable: false),
                        HairDresserId = c.String(maxLength: 128),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BarbershopHairDresserId)
                .ForeignKey("dbo.Barbershops", t => t.BarbershopId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.HairDresserId)
                .Index(t => t.BarbershopId)
                .Index(t => t.HairDresserId);
            
            CreateTable(
                "dbo.Barbershops",
                c => new
                    {
                        BarbershopId = c.Guid(nullable: false),
                        Name = c.String(),
                        Lat = c.Double(nullable: false),
                        Lng = c.Double(nullable: false),
                        LocationTitle = c.String(),
                        BusinessLicense = c.String(),
                    })
                .PrimaryKey(t => t.BarbershopId);
            
            CreateTable(
                "dbo.MembershipCards",
                c => new
                    {
                        MembershipCardId = c.Guid(nullable: false),
                        CustomerId = c.String(maxLength: 128),
                        BarbershopId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.MembershipCardId)
                .ForeignKey("dbo.Barbershops", t => t.BarbershopId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId)
                .Index(t => t.BarbershopId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        NickName = c.String(maxLength: 10),
                        Sign = c.String(maxLength: 50),
                        BirthDay = c.DateTime(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        Customer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Followers",
                c => new
                    {
                        FollowerId = c.Guid(nullable: false),
                        CustomerId = c.String(maxLength: 128),
                        HairDresserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.FollowerId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.AspNetUsers", t => t.HairDresserId)
                .Index(t => t.CustomerId)
                .Index(t => t.HairDresserId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        NickName = c.String(maxLength: 10),
                        Sign = c.String(maxLength: 50),
                        BirthDay = c.DateTime(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        Customer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.UserId)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        Customer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserRoles", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.MembershipCards", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.AspNetUserLogins", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followers", "HairDresserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.BarbershopHairDressers", "HairDresserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followers", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.AspNetUserClaims", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.MembershipCards", "BarbershopId", "dbo.Barbershops");
            DropForeignKey("dbo.BarbershopHairDressers", "BarbershopId", "dbo.Barbershops");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "Customer_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "Customer_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Followers", new[] { "HairDresserId" });
            DropIndex("dbo.Followers", new[] { "CustomerId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "Customer_Id" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.MembershipCards", new[] { "BarbershopId" });
            DropIndex("dbo.MembershipCards", new[] { "CustomerId" });
            DropIndex("dbo.BarbershopHairDressers", new[] { "HairDresserId" });
            DropIndex("dbo.BarbershopHairDressers", new[] { "BarbershopId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Followers");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.Customers");
            DropTable("dbo.MembershipCards");
            DropTable("dbo.Barbershops");
            DropTable("dbo.BarbershopHairDressers");
        }
    }
}
