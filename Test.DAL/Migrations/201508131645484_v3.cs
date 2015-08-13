namespace Test.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teachers", "StudentLectureGrade_ID", "dbo.StudentLectureGrades");
            DropIndex("dbo.Teachers", new[] { "StudentLectureGrade_ID" });
            AddColumn("dbo.Lectures", "StudentLectureGrade_ID", c => c.Int());
            CreateIndex("dbo.Lectures", "StudentLectureGrade_ID");
            AddForeignKey("dbo.Lectures", "StudentLectureGrade_ID", "dbo.StudentLectureGrades", "ID");
            DropColumn("dbo.Teachers", "StudentLectureGrade_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "StudentLectureGrade_ID", c => c.Int());
            DropForeignKey("dbo.Lectures", "StudentLectureGrade_ID", "dbo.StudentLectureGrades");
            DropIndex("dbo.Lectures", new[] { "StudentLectureGrade_ID" });
            DropColumn("dbo.Lectures", "StudentLectureGrade_ID");
            CreateIndex("dbo.Teachers", "StudentLectureGrade_ID");
            AddForeignKey("dbo.Teachers", "StudentLectureGrade_ID", "dbo.StudentLectureGrades", "ID");
        }
    }
}
