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
            int[] nums = new int[] { 1, 8, 12, 6, 55 };
            int temp = 0;
     
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length ; j++)
                {
                    if (nums[j]<nums[i])
                    {
                         temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                                         
                    }
                }
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
