namespace Test.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondCmt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lectures", "Teacher_ID", c => c.Int());
            CreateIndex("dbo.Lectures", "Teacher_ID");
            AddForeignKey("dbo.Lectures", "Teacher_ID", "dbo.Teachers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lectures", "Teacher_ID", "dbo.Teachers");
            DropIndex("dbo.Lectures", new[] { "Teacher_ID" });
            DropColumn("dbo.Lectures", "Teacher_ID");
        }
    }
}
