namespace Test.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentLectureGrades", "Lecture_ID", c => c.Int());
            AddColumn("dbo.StudentLectureGrades", "Student_ID", c => c.Int());
            CreateIndex("dbo.StudentLectureGrades", "Lecture_ID");
            CreateIndex("dbo.StudentLectureGrades", "Student_ID");
            AddForeignKey("dbo.StudentLectureGrades", "Lecture_ID", "dbo.Lectures", "ID");
            AddForeignKey("dbo.StudentLectureGrades", "Student_ID", "dbo.Students", "ID");
            DropColumn("dbo.StudentLectureGrades", "StudentId");
            DropColumn("dbo.StudentLectureGrades", "LectureId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentLectureGrades", "LectureId", c => c.Int(nullable: false));
            AddColumn("dbo.StudentLectureGrades", "StudentId", c => c.Int(nullable: false));
            DropForeignKey("dbo.StudentLectureGrades", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.StudentLectureGrades", "Lecture_ID", "dbo.Lectures");
            DropIndex("dbo.StudentLectureGrades", new[] { "Student_ID" });
            DropIndex("dbo.StudentLectureGrades", new[] { "Lecture_ID" });
            DropColumn("dbo.StudentLectureGrades", "Student_ID");
            DropColumn("dbo.StudentLectureGrades", "Lecture_ID");
        }
    }
}
