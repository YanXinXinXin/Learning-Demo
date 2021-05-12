using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleApp1
{
    class Student
    {

        public int Id { get; set; }
        public int age;
        public void Show()
        {
            Console.WriteLine("this is Show");
        }
        public string Show2(string name)
        {
            return $"你好，{name}";
        }
    }

    class Program
    {

        public void Show()
        {

        }


        static void Main(string[] args)
        {

            {
                //获取的是绝对路径 exe文件所在的路径
                //动态引用了一个dll文件 类库
                Assembly ass = Assembly.LoadFile(Environment.CurrentDirectory+ @"\libs\StudentManger.dll");
                // Console.WriteLine(Environment.CurrentDirectory + @"\libs\StudentManger.dll");

                foreach (var types in ass.GetTypes())
                {
                    Console.WriteLine(types.Name);
                    Console.WriteLine(types.FullName);
                }

                var user = ass.GetTypes().First(s => !s.IsAbstract && s.IsClass);

                    //如何创建对象
               object  obj2=   ass.CreateInstance(user.FullName);
                user.GetProperty("Name").SetValue(obj2, "颜末");
                user.GetProperty("Age").SetValue(obj2, 12);
                user.GetMethod("SayHi").Invoke(obj2, new object[0]);

            }

            //反射
            //1.通过反射的方法.可以遍历成员.并调用成员

            object obj = new Student();
            Type type = obj.GetType();
            //Console.WriteLine(type.Namespace);
            //Console.WriteLine(type.FullName);
            //Console.WriteLine(type.Name);


            #region 获取所有字段
            foreach (var filed in type.GetFields())
            {
                if (filed.Name == "age")
                {
                    Console.WriteLine(filed.Name);
                    Console.WriteLine(filed.FieldType.FullName);
                    filed.SetValue(obj, 12);
                    Console.WriteLine(filed.GetValue(obj));
                }

            }
            #endregion

            //获取特定字段
            type.GetField("age").SetValue(obj, 12);
            Console.WriteLine(type.GetField("age").GetValue(obj));


            #region 获取属性
            foreach (var property in type.GetProperties())
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.PropertyType.FullName);
                property.SetValue(obj, 56);
                Console.WriteLine(property.GetValue(obj));
            }
            #endregion 获取特定属性
            var id = type.GetProperty("Id");
            #region
            id.SetValue(obj, 55);
            Console.WriteLine(id.GetValue(obj));
            #endregion

            #region 获取公共的方法
            foreach (var method in type.GetMethods())
            {
                //属性的本质 Set get对应的就是方法
                Console.WriteLine(method.Name);
            }
            //Invoke()调用
            type.GetMethod("Show").Invoke(obj, new object[0]);
          var result=   type.GetMethod("Show2").Invoke(obj, new object[] { "颜末"});
            Console.WriteLine(result.ToString());
            #endregion
        }
    }
}
