using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL.Entities
{
    public class Teacher : BaseEntity
    {
        public double Salary { get; set; }
        public int LectureHours { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }

}
