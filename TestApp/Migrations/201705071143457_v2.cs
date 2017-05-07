namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Students", new[] { "StudentCode" });
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "StudentCode", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Students", new[] { "Id", "StudentCode" });
            CreateIndex("dbo.Students", "StudentCode", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "StudentCode" });
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "StudentCode", c => c.String());
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Students", "Id");
            CreateIndex("dbo.Students", "StudentCode", unique: true);
        }
    }
}
