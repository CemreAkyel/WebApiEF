namespace Test.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstCmt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lectures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Credit = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StudentLectureGrades",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Grade = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParentContactNo = c.String(),
                        Class = c.String(),
                        Number = c.String(),
                        Name = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        StudentLectureGrade_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.StudentLectureGrades", t => t.StudentLectureGrade_ID)
                .Index(t => t.StudentLectureGrade_ID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Salary = c.Double(nullable: false),
                        LectureHours = c.Int(nullable: false),
                        Number = c.String(),
                        Name = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        StudentLectureGrade_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.StudentLectureGrades", t => t.StudentLectureGrade_ID)
                .Index(t => t.StudentLectureGrade_ID);
            
            CreateTable(
                "dbo.TeacherStudents",
                c => new
                    {
                        Teacher_ID = c.Int(nullable: false),
                        Student_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_ID, t.Student_ID })
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_ID, cascadeDelete: true)
                .Index(t => t.Teacher_ID)
                .Index(t => t.Student_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "StudentLectureGrade_ID", "dbo.StudentLectureGrades");
            DropForeignKey("dbo.Students", "StudentLectureGrade_ID", "dbo.StudentLectureGrades");
            DropForeignKey("dbo.TeacherStudents", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.TeacherStudents", "Teacher_ID", "dbo.Teachers");
            DropIndex("dbo.TeacherStudents", new[] { "Student_ID" });
            DropIndex("dbo.TeacherStudents", new[] { "Teacher_ID" });
            DropIndex("dbo.Teachers", new[] { "StudentLectureGrade_ID" });
            DropIndex("dbo.Students", new[] { "StudentLectureGrade_ID" });
            DropTable("dbo.TeacherStudents");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.StudentLectureGrades");
            DropTable("dbo.Lectures");
        }
    }
}
