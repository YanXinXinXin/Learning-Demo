using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        public string Name { get; set; }

        private int age;
        public int Age
        {
            get => age;
            set
            {
                if (value < 18)
                {
                    if (YounEvent != null) YounEvent();

                }
                else if (value < 40&&value>100)
                {
                    if (OldEvent != null) OldEvent();
                }
                //else if(value<18&&value>0)
                //{
                //    if (MiddleEvent != null) MiddleEvent();
                //}
                else if (value > 120)
                {
                    if (WeiZhi != null) WeiZhi(value);
                }

            }
        }

        public event Action YounEvent;
        public event Action MiddleEvent;
        public event Action OldEvent;
        public event Func<int,int> WeiZhi;

    }
}
