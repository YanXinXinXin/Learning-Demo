using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

           /// <summary>
           /// 学习Linq
           /// </summary>
           /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(" 97, 50, 99, 87, 60");
            int[] scores = new int[] { 97, 50, 99, 87, 60 };
            Console.WriteLine("查询大于60的分值");
             //查询大于60的分值
            IEnumerable<int> ScoreQuery=from s in scores
                                 where s>60
                                 select s;

            foreach (var item in ScoreQuery)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("能整被2整除的分值且倒叙排序");
            /* ************************************/
            var list = from a in scores
                       where a % 2 == 0
                       orderby a descending
                       select a;
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }


            var result = from stu in list

                         select stu;
            double evenNumCount = result.Average();
            Console.WriteLine(evenNumCount);

            List<ClassInfo> classinfo = new List<ClassInfo>() {
            new ClassInfo{Id=1,ClassName="1801"},
             new ClassInfo{Id=2,ClassName="1802" }
            };
            List<Student> students = new List<Student>()
        {
          new Student { First="小",
                Last="红",
                ID=111,
                Street="123 Main Street",
                City="CQ",
                Scores= new List<int> { 97, 92, 81, 60 }, ClassInfoID=1 },
            new Student { First="小",
                Last="蓝",
                ID=111,
                Street="123 Main Street",
                City="BJ",
                Scores= new List<int> { 97, 92, 81, 60 }, ClassInfoID=1 },
              new Student { First="小",
                Last="黑",
                ID=111,
                Street="123 Main Street",
                City="SH",
                Scores= new List<int> { 97, 92, 81, 60 }, ClassInfoID=1 },
                new Student { First="小",
                Last="橙",
                ID=111,
                Street="123 Main Street",
                City="CQ",
                Scores= new List<int> { 97, 92, 81, 60 }, ClassInfoID=2 },
                  new Student { First="小",
                Last="黄",
                ID=111,
                Street="123 Main Street",
                City="CQ",
                Scores= new List<int> { 97, 92, 81, 60 }, ClassInfoID=2 },
            new Student { First="小",
                Last="白",
                ID=112,
                Street="124 Main Street",
                City="BJ",
                Scores= new List<int> { 75, 84, 91, 39 }, ClassInfoID=2 },
            new Student { First="小",
                Last="蓝",
                ID=113,
                Street="125 Main Street",
                City="SH",
                Scores= new List<int> { 88, 94, 65, 91 }
            , ClassInfoID=1},
                 
        };
            List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher { First="Ann", Last="Beebe", ID=945, City="CQ" },
            new Teacher { First="Alex", Last="Robinson", ID=956, City="BJ" },
            new Teacher { First="Michiyo", Last="Sato", ID=972, City="SH" }
        };

            var data = (from student in students
                        where student.City == "CQ"
                        select student.Last)
                        .Concat(from teacher in teachers
                                where teacher.City == "CQ"
                                select teacher.Last
                                );

            foreach (var item in data)
            {
                Console.WriteLine(item);
         
            }

            Console.WriteLine("班级与学生");
            Console.WriteLine("输出所在班级的学生");
            var StudentOnClass = from stu in students
                                 join c in classinfo
                                 on stu.ClassInfoID equals c.Id
                               
                       select new
                       {
                           StudentName = stu.First + stu.Last,
                           ClassName = c.ClassName

                       };
            foreach (var item in StudentOnClass)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("输出所在同一个城市的班级的学生");

            var StudentOnClass2 = from stu in students
                                  join c in classinfo
                                  on stu.ClassInfoID equals c.Id
                                  group stu by stu.City[0]   into k
                                  orderby k.Key descending
                                  select k;



            foreach ( IGrouping<int,Student> StudentGroup in StudentOnClass2)
            {
                Console.WriteLine(StudentGroup.Key);
                foreach (var item in StudentGroup)
                {
                    Console.WriteLine($"{item.First}{item.Last}");
                }
            }

        }
    }
}
