using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL.Entities
{
    public class Lecture
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public float Credit { get; set; }

    }
}
