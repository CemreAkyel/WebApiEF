using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL.Entities
{
    public class StudentLectureGrade
    {
        public int ID { get; set; }
        public Student Student { get; set; }
        public Lecture Lecture { get; set; }
        public float Grade { get; set; }
    }
}
