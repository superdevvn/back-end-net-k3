namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _03 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EntryDate = c.DateTime(nullable: false),
                        View = c.Int(nullable: false),
                        Purchases = c.Int(nullable: false),
                        Picture = c.String(nullable: false, maxLength: 100),
                        IdGenre = c.Guid(nullable: false),
                        IdProducer = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.IdGenre, cascadeDelete: true)
                .ForeignKey("dbo.Producers", t => t.IdProducer, cascadeDelete: true)
                .Index(t => t.IdGenre)
                .Index(t => t.IdProducer);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "IdProducer", "dbo.Producers");
            DropForeignKey("dbo.Books", "IdGenre", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "IdProducer" });
            DropIndex("dbo.Books", new[] { "IdGenre" });
            DropTable("dbo.Books");
        }
    }
}
