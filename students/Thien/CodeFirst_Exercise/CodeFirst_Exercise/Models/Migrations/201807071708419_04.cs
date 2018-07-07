namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _04 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                        Address = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        IdPurchaseHistory = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PurchaseHistories", t => t.IdPurchaseHistory, cascadeDelete: true)
                .Index(t => t.IdPurchaseHistory);
            
            CreateTable(
                "dbo.PurchaseHistories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IdPay = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "IdPurchaseHistory", "dbo.PurchaseHistories");
            DropIndex("dbo.Customers", new[] { "IdPurchaseHistory" });
            DropTable("dbo.PurchaseHistories");
            DropTable("dbo.Customers");
        }
    }
}
