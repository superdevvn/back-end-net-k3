namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _005 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Roles", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Roles", new[] { "Code" });
        }
    }
}
