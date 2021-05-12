using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManger
{
    public class User
    {
        public string  Name { get; set; }
        public int Age { get; set; }
        public void SayHi()
        {
            Console.WriteLine($"你好，我是{Name}今年{Age}岁了");
            Game();
        }
        public void Game() {

            Console.WriteLine($"{Name}再玩游戏");
        }
    }
}
