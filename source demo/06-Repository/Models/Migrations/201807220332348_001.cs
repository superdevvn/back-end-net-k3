namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        code = c.String(),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        roleId = c.Guid(nullable: false),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Roles", t => t.roleId, cascadeDelete: true)
                .Index(t => t.roleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "roleId", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "roleId" });
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
