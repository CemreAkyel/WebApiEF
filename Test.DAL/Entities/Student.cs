using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL.Entities
{
    public class Student : BaseEntity
    {
        public string ParentContactNo { get; set; }
        public string Class { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }

    public enum Gender
    {
        Bayan = 0,
        Erkek = 1
    }
}
