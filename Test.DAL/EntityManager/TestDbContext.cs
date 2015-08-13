using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DAL.Entities;

namespace Test.DAL.EntityManager
{
    public class TestDbContext : DbContext
    {
        public TestDbContext()
            : base("TestDbConnection")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<StudentLectureGrade> SLGrade { get; set; }
    }
}
