namespace Test.DAL.Migrations
{
    using EfEnumToLookup.LookupGenerator;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Test.DAL.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<Test.DAL.EntityManager.TestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Test.DAL.EntityManager.TestDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var enumToLookup = new EnumToLookup();

            enumToLookup.Apply(context);

            Student s1 = new Student();
            s1.Name = "Ozan";
            s1.LastName = "Erdem";
            s1.Gender = Gender.Erkek;
            //s1.BirthDate = new DateTime(1984, 8, 13);
            s1.Class = "Tecno";
            //s1.CreateDate = DateTime.Now;
            s1.Number = "007G3";


            Teacher t1 = new Teacher();
            t1.Name = "Süleyman";
            t1.Number = "T004";
            t1.Salary = 5000;
            t1.LectureHours = 29;

            Lecture l1 = new Lecture();
            l1.Code = "Fizik102";
            l1.Credit = 3;
            l1.Name = "Fizik";
            Lecture l2 = new Lecture();
            l2.Code = "Kimya201";
            l2.Credit = 6;
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
