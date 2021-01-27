using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;
namespace ConsoleApp1
{
    class Program
    {
        //static XmlDocument doc = new XmlDocument();
        public delegate int Countdelegate(int a, int b);

           public  static int Counts(int a ,int b,Countdelegate dlg)
        {
               
            return dlg(a,b);
        }
        private delegate void IntMethodInvoker(int x);
        static void ShowInt(int x)
        {
            Console.WriteLine("这是一个数字：" + x);
        }
        static void Main(string[] args)
        {
            //int a = 10;
            ////调用委托形式一
            //IntMethodInvoker showIntMethod = new IntMethodInvoker(ShowInt);
            //showIntMethod(a);

            //Thread.CurrentThread.Name = "Main Thread";
            ////Thread t = new Thread(ka);
            ////t.Start();
            ////Thread h = new Thread(()=>JIansuan(9, 5, (k, f) => k*f));
            //Thread h = new Thread(StudentXml); 
            //h.Start();

            //Console.WriteLine(h.IsAlive);
            //h.Join();

            //Thread x = new Thread(StudentXm2);
            //x.Start();
            //x.Join();
            //Program.Counts(5, 6, (e, f) => e - f)
            var dmoe = 0;
            Thread w = new Thread(
                
                () => dmoe=Counts(5, 6, (e, f) => e - f));

            w.Start();
       
            w.Join();

            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine("2秒一次");

            }

            Console.WriteLine(w.IsAlive);
        }
        public delegate int  Actiondelegate(int a ,int b);

        //public static int Count(int a ,int b,Actiondelegate dlg) {
        //    Console.WriteLine("111111111112s");
        //    return dlg(a,b);
        //        }
      

        public delegate string   DegName(string FistName, string LastName);
        public static int JIansuan(int a,int b,Actiondelegate deg) {
            return deg(a,b);
        }
        static string Demo(string FistName,string LastName, DegName dgl) {
            return dgl(FistName,LastName);
        }
       static void ka()
        {
            for (int i = 0; i < 5; i++)
            {
              Console.WriteLine("--------------");
               
            }

           
        }

      
        //static void StudentXm2()
        //{
        //    Thread.Sleep(2000);
        //    Console.WriteLine("X线程");
        //    doc.Load("Student.xml");
              
        //    XmlNode root = doc.DocumentElement;
        //    Console.WriteLine(root.OuterXml);
        //    Console.WriteLine(doc.SelectSingleNode("School/class[@name='001']/Studen[@id='2']").Attributes["name"].Value);
        //    Console.WriteLine(Program.Demo("律政先锋", "张益达", ( a,  b)=> { return a + b; }) );
        //}
       
        static void StudentXml() {
            //创建Xml文档对象
            XmlDocument doc = new XmlDocument();
            //加载特定xml文件
            doc.Load("Student.xml");
            //获取根节点
        XmlNode root= doc.DocumentElement;
            Console.WriteLine(root.OuterXml);
            foreach (XmlNode clsNode in root.ChildNodes)
            {
                Console.WriteLine("班级名字");
                Console.WriteLine(clsNode.Name);
                Console.WriteLine("姓名");
                Console.WriteLine(clsNode.Attributes["name"].Value);
            }
            Console.WriteLine(doc.SelectSingleNode("School/class[@name='001']/Studen[@id='2']")
                .Attributes["name"].Value);
            Console.WriteLine("请输入你要查询的班级");
          var Name=Console.ReadLine();
            foreach (XmlNode clsNode in root.ChildNodes)
            {
                if (Name== clsNode.Attributes["name"].Value)
                {
                    Console.WriteLine(clsNode.InnerXml);
                }
            }

      
        }
    }
}
