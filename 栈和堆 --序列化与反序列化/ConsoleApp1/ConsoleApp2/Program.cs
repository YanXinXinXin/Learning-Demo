using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
     class Student
    {
        //类里里面有字段 属性 方法
    }
    //结构和类的区别
    /*1 结构只使用字段的话，可以不实例化直接使用
      2 结构不能直接给字段和属性初始化
    3 结构不能显示编写无参构造函数,结构默认的无参构造函数不会自动消失 (类会)
      4 结构如果需要给字段或属性赋初始值则必须在构造函数中赋值且全部赋值
      5 如果要是用结构的属性或方法，则必须初始化对象之后再用
     * */
    //结构
    struct StudentStudent
    {
        public int id;
        public string name;
        public StudentStudent(int _id)
        {
            id = _id;
            name = "123";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
