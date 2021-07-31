namespace TampaBayCoffee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoffeeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coffees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Name = c.String(),
                        Origin = c.String(),
                        Process = c.String(),
                        ElevationRangeInMeters = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Coffees");
        }
    }
}
