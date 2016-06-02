namespace HDO2O.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVerifyState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BarbershopHairDressers", "VerifyState", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BarbershopHairDressers", "VerifyState");
        }
    }
}
