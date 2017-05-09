namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReorderThreshold : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InventoryItems", "ReorderThreshold", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InventoryItems", "ReorderThreshold");
        }
    }
}
