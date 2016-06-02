namespace HDO2O.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDiscount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Barbershops", "SerialNumber", c => c.String());
            AddColumn("dbo.Barbershops", "Discount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Barbershops", "Discount");
            DropColumn("dbo.Barbershops", "SerialNumber");
        }
    }
}
