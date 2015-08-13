namespace Test.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "BirthDate", c => c.DateTime());
            AlterColumn("dbo.Students", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Teachers", "BirthDate", c => c.DateTime());
            AlterColumn("dbo.Teachers", "CreateDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Teachers", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
