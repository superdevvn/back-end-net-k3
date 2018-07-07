namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _06 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pays", "IdCustomer", "dbo.Customers");
            DropIndex("dbo.Pays", new[] { "IdCustomer" });
            CreateIndex("dbo.PurchaseHistories", "IdPay");
            AddForeignKey("dbo.PurchaseHistories", "IdPay", "dbo.Pays", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseHistories", "IdPay", "dbo.Pays");
            DropIndex("dbo.PurchaseHistories", new[] { "IdPay" });
            CreateIndex("dbo.Pays", "IdCustomer");
            AddForeignKey("dbo.Pays", "IdCustomer", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
