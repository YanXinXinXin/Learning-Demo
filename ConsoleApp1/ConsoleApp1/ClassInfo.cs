using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class ClassInfo
    {
        public int Id { get; set; }
        public string ClassName  { get; set; }
        public virtual ICollection<Student>  Student{ get; set; }
    }
}
