namespace TampaBayCoffee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoffeeShopsAddedIsRoasterAndCoffeeBrandsUsed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CoffeeShops", "IsRoaster", c => c.Boolean(nullable: false));
            AddColumn("dbo.CoffeeShops", "CoffeeBrandsUsed", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CoffeeShops", "CoffeeBrandsUsed");
            DropColumn("dbo.CoffeeShops", "IsRoaster");
        }
    }
}
