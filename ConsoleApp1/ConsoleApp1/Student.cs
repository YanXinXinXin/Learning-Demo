using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public List<int> Scores;
        public int ClassInfoID { get; set; }
        public virtual ClassInfo ClassInfo { get; set; }
    }
}
