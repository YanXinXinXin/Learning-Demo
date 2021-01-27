using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        delegate int NumberChanger(int n);

        static int num = 10;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }
        static void Main(string[] args)
        {
            NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
            };
            nc(10);

        }
    }
}
