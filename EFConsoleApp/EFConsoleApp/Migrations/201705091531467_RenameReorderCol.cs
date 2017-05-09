namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameReorderCol : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.InventoryItems", "ReorderThreshhold", "ReorderThreshold");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InventoryItems", "ReorderThreshhold", c => c.Int(nullable: false));
            DropColumn("dbo.InventoryItems", "ReorderThreshold");
        }
    }
}
