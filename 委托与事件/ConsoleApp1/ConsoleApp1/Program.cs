using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void MyDel();
    public delegate string  MyDel2();
    class Program
    {
        //委托
        //委托是一个引用 类型
        //委托类型是装方法的种数据类型
        //1. 委托需要设定方法签名(返回值类型与参数列表)
        //语法:Public delegate void MyDelgate();

        static void Demo() {
            Console.WriteLine("Demo");
        }
       public void Demo2()
        {
            Console.WriteLine("Demo2");
        }
        public string  Demo3()
        {
            Console.WriteLine("Demo3");
            return "123";
        }
        static void Demo4(int num,int num2)
        {
            Console.WriteLine("Demo4");
        }
        public string Demo5(string str)
        {
            Console.WriteLine("Demo5"+str);
            return str ;
        }
        static void Main(string[] args)
        {
            MyDel del = Program.Demo;

            MyDel del2 = new  Program().Demo2;

            MyDel2 del3 = new Program().Demo3;
            Console.WriteLine(del3());

            Action act = Program.Demo;
            act();

            Action<int ,int> act2 = Program.Demo4;
            act2(1,1);

            Func<string,string > func = new Program().Demo5;
            Console.WriteLine(func("嘻嘻哈哈"));
       
        }
    }
}
