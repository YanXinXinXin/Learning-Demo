using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            //事件订阅 这个事件调用这个方法
            stu.YounEvent += Stu_YounEvent;
            stu.OldEvent += Stu_OldEvent;
            stu.WeiZhi += Stu_WeiZhi;

            //for (int i = 0; i < 1; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    if (num < 0)
            //    {
            //        return;
            //    }
            //    stu.Age = num;
            //}
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    return;
                }
                stu.Age = num;
            }
        }

        private static int Stu_WeiZhi(int arg)
        {
            Console.WriteLine( $"我录入了一个错误年龄{arg}");
            return arg;
        }

        private static void Stu_OldEvent()
        {
            Console.WriteLine("我录入了一个老人");
        }

        private static void Stu_YounEvent()
        {
            Console.WriteLine("我录入了一个年轻人");
        }
    }
}
