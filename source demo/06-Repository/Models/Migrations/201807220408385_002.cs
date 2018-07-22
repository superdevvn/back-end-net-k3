namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Roles", "code", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "username", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Roles", "code", unique: true, name: "IX_username");
            CreateIndex("dbo.Users", "username", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "username" });
            DropIndex("dbo.Roles", "IX_username");
            AlterColumn("dbo.Users", "username", c => c.String());
            AlterColumn("dbo.Roles", "code", c => c.String());
        }
    }
}
