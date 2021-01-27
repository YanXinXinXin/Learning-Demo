using ConsoleApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            //值类型的特点:传值
            // 1:在赋值的时候会创建一个副本，修改其中一个，另一个不会有任何变化。
            int a = 12;
            int b = a;
            Console.WriteLine($"{a},{b}");
            Console.WriteLine(object.ReferenceEquals(a, b));

            //栈(目录)性能很快 且数据有序  目的：用来检索数据(检索堆里面的类容)以及对应内存地址的数据    
            //堆(存东西，无序)
            //栈里面引用堆

            //引用类型的特点
            //1:数据量大，开辟空间和赋值时会耗费大量的内存空间和性能
            /* 2:当赋值的时候传递的是数据的内存地址，如果其中一个变量修改数据则
            另一个变量对应的数据会相应的发生变化*/
            //字符串在做拼接操作时，会开辟一个新的空间把新的结果存放进去

            int[] arr = new int[] { 1, 2, 3 };
            var arr2 = arr;
            Console.WriteLine(object.ReferenceEquals(arr, arr2));//指向同一个内存地址
            arr[0] *= 15;
            Console.WriteLine($"{arr[0]},{arr2[0]}");

            //暂存池 ( 字符串在以双引号创建的时候存放)\
            string str = "123";
            string str2 = "456";
            string str3 = "123";
            string str4 = new string(new char[] { '1', '2', '3' });
            Console.WriteLine(str4[0]);
            Console.WriteLine(object.ReferenceEquals(str, str4));
            Sex sex = (Sex) int.Parse( Console.ReadLine());
            Sex sex1 = Sex.女;
            switch (sex)
            {
                case Sex.男:
                    Console.WriteLine(Sex.男);
                    break;
                case Sex.女:
                    Console.WriteLine(Sex.女);
                    break;             
                default:
                    Console.WriteLine("录入值有问题");
                    break;
                    
            }
        }
    }
}
