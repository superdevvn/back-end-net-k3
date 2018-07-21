namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _05 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pays",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IdCustomer = c.Guid(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        State = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.IdCustomer, cascadeDelete: true)
                .Index(t => t.IdCustomer);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pays", "IdCustomer", "dbo.Customers");
            DropIndex("dbo.Pays", new[] { "IdCustomer" });
            DropTable("dbo.Pays");
        }
    }
}
