namespace CrmBL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigraion : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Checks", "Sell_SellId", "dbo.Sells");
            DropForeignKey("dbo.Checks", "Sell_SellId1", "dbo.Sells");
            DropForeignKey("dbo.Sells", "Check_CheckId1", "dbo.Checks");
            DropForeignKey("dbo.Sells", "Check_CheckId", "dbo.Checks");
            DropIndex("dbo.Checks", new[] { "Sell_SellId" });
            DropIndex("dbo.Checks", new[] { "Sell_SellId1" });
            DropIndex("dbo.Sells", new[] { "Check_CheckId" });
            DropIndex("dbo.Sells", new[] { "Check_CheckId1" });
            DropColumn("dbo.Sells", "CheckId");
            DropColumn("dbo.Sells", "CheckId");
            RenameColumn(table: "dbo.Sells", name: "Check_CheckId1", newName: "CheckId");
            RenameColumn(table: "dbo.Sells", name: "Check_CheckId", newName: "CheckId");
            AlterColumn("dbo.Sells", "CheckId", c => c.Int(nullable: false));
            AlterColumn("dbo.Sells", "CheckId", c => c.Int(nullable: false));
            CreateIndex("dbo.Sells", "CheckId");
            AddForeignKey("dbo.Sells", "CheckId", "dbo.Checks", "CheckId", cascadeDelete: true);
            DropColumn("dbo.Checks", "Sell_SellId");
            DropColumn("dbo.Checks", "Sell_SellId1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Checks", "Sell_SellId1", c => c.Int());
            AddColumn("dbo.Checks", "Sell_SellId", c => c.Int());
            DropForeignKey("dbo.Sells", "CheckId", "dbo.Checks");
            DropIndex("dbo.Sells", new[] { "CheckId" });
            AlterColumn("dbo.Sells", "CheckId", c => c.Int());
            AlterColumn("dbo.Sells", "CheckId", c => c.Int());
            RenameColumn(table: "dbo.Sells", name: "CheckId", newName: "Check_CheckId");
            RenameColumn(table: "dbo.Sells", name: "CheckId", newName: "Check_CheckId1");
            AddColumn("dbo.Sells", "CheckId", c => c.Int(nullable: false));
            AddColumn("dbo.Sells", "CheckId", c => c.Int(nullable: false));
            CreateIndex("dbo.Sells", "Check_CheckId1");
            CreateIndex("dbo.Sells", "Check_CheckId");
            CreateIndex("dbo.Checks", "Sell_SellId1");
            CreateIndex("dbo.Checks", "Sell_SellId");
            AddForeignKey("dbo.Sells", "Check_CheckId", "dbo.Checks", "CheckId");
            AddForeignKey("dbo.Sells", "Check_CheckId1", "dbo.Checks", "CheckId");
            AddForeignKey("dbo.Checks", "Sell_SellId1", "dbo.Sells", "SellId");
            AddForeignKey("dbo.Checks", "Sell_SellId", "dbo.Sells", "SellId");
        }
    }
}
