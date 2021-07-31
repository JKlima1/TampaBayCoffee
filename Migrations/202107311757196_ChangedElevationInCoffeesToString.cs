namespace TampaBayCoffee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedElevationInCoffeesToString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coffees", "ElevationRangeInMeters", c => c.String());
            DropColumn("dbo.Coffees", "ElevationRangeInMeters");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coffees", "ElevationRangeInMeters", c => c.Int(nullable: false));
            DropColumn("dbo.Coffees", "ElevationRangeInMeters");
        }
    }
}
