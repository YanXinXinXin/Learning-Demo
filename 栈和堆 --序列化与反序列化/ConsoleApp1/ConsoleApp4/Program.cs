using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp4
{
    //序列化   
    [Serializable]
    class Student {

        public int Id { get; set; }
        public string Name  { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List<Student> lists = new List<Student>() {
            //new Student(){ Id=1,Name="ka" },
            // new Student(){ Id=2,Name="wa" },
            //  new Student(){ Id=3,Name="yi" },
            //   new Student(){ Id=4,Name="dd" },
            //};
            //BinaryFormatter bf = new BinaryFormatter();
            //using (FileStream fs=new FileStream("path.ka",FileMode.Create))
            //{
            //    bf.Serialize(fs, lists);
            //}


            //反序列化
            //BinaryFormatter bf = new BinaryFormatter();
            //using (FileStream fs = new FileStream("path.ka", FileMode.Open))
            //{
            //  var data=   bf.Deserialize(fs) as List<Student>;
            //    foreach (var item in data)
            //    {
            //        Console.WriteLine($"id:{item.Id} \t\n name :{item.Name}");
            //    }
            //}

            int[] data = new int[] { 1, 9, 2, 6, 15 };
            int  temp = 0;
            for (int i = 0; i < data.Length-1; i++)
            {
                for (int j = i+1; j < data.Length; j++)
                {
                    if (data[j]<data[i])
                    {
                        temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
