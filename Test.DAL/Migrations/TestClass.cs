using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DAL.Entities;
using Test.DAL.EntityManager;

namespace Test.DAL.Migrations
{
    public class TestClass
    {
        public void Seeder(TestDbContext context)
        {
            Student s1 = new Student();
            s1.Name = "Galip";
            s1.LastName = "Erdem";
            s1.Gender = Gender.Erkek;
            //s1.BirthDate = new DateTime(1984, 8, 13);
            s1.Class = "Classic";
            //s1.CreateDate = DateTime.Now;
            s1.Number = "007G3";


            Teacher t1 = new Teacher();
            t1.Name = "Hilmi";
            t1.Number = "T003";
            t1.Salary = 2000;
            t1.LectureHours = 33;

            Lecture l1 = new Lecture();
            l1.Code = "Fizik101";
            l1.Credit = 3;
            l1.Name = "Fizik";
            Lecture l2 = new Lecture();
            l2.Code = "Kimya101";
            l2.Credit = 4;
            l2.Name = "Kimya";

            t1.Lectures = new List<Lecture>();
            t1.Lectures.Add(l1);
            t1.Lectures.Add(l2);

            s1.Teachers = new List<Teacher>();
            s1.Teachers.Add(t1);

            context.Students.Add(s1);
            context.Teachers.Add(t1);
            context.Lectures.Add(l1);
            context.Lectures.Add(l2);

            context.SaveChanges();
        }
    }
}
