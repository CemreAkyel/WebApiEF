using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender Gender { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
