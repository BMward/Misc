namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InventoryItems",
                c => new
                    {
                        InventoryId = c.Int(nullable: false, identity: true),
                        ItemDescription = c.String(),
                        AcquisitionCost = c.Double(nullable: false),
                        ListPrice = c.Double(nullable: false),
                        InStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InventoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InventoryItems");
        }
    }
}
