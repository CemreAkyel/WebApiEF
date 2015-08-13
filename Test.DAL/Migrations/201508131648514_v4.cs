namespace Test.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lectures", "StudentLectureGrade_ID", "dbo.StudentLectureGrades");
            DropForeignKey("dbo.Students", "StudentLectureGrade_ID", "dbo.StudentLectureGrades");
            DropIndex("dbo.Lectures", new[] { "StudentLectureGrade_ID" });
            DropIndex("dbo.Students", new[] { "StudentLectureGrade_ID" });
            AddColumn("dbo.StudentLectureGrades", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.StudentLectureGrades", "LectureId", c => c.Int(nullable: false));
            DropColumn("dbo.Lectures", "StudentLectureGrade_ID");
            DropColumn("dbo.Students", "StudentLectureGrade_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "StudentLectureGrade_ID", c => c.Int());
            AddColumn("dbo.Lectures", "StudentLectureGrade_ID", c => c.Int());
            DropColumn("dbo.StudentLectureGrades", "LectureId");
            DropColumn("dbo.StudentLectureGrades", "StudentId");
            CreateIndex("dbo.Students", "StudentLectureGrade_ID");
            CreateIndex("dbo.Lectures", "StudentLectureGrade_ID");
            AddForeignKey("dbo.Students", "StudentLectureGrade_ID", "dbo.StudentLectureGrades", "ID");
            AddForeignKey("dbo.Lectures", "StudentLectureGrade_ID", "dbo.StudentLectureGrades", "ID");
        }
    }
}
