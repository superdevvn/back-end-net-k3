namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _003 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Roles", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Roles", "Name", c => c.String());
            DropColumn("dbo.Roles", "Description");
        }
    }
}
