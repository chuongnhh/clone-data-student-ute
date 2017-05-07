namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
           // CreateIndex("dbo.Students", "StudentCode", unique: true);
        }
        
        public override void Down()
        {
           // DropIndex("dbo.Students", new[] { "StudentCode" });
        }
    }
}
