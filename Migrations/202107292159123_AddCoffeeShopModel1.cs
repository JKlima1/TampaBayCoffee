namespace TampaBayCoffee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoffeeShopModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoffeeShops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        State = c.String(),
                        County = c.String(),
                        Zip_Code = c.String(),
                        StreetName = c.String(),
                        Add_Number = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Longitude = c.Single(nullable: false),
                        Latitude = c.Single(nullable: false),
                        NatGrid_Coord = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CoffeeShops");
        }
    }
}
