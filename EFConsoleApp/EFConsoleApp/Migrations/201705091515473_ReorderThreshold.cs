namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReorderThreshold : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.InventoryItems", "ReorderThreshhold", "ReorderThreshold");
        }

        public override void Down()
        {
            DropColumn("dbo.InventoryItems", "ReorderThreshold");
        }
    }
}
