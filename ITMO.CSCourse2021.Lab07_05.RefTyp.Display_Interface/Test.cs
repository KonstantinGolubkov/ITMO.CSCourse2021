using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab07_05.RefTyp.Display_Interface
{
    class Test
    {   
        static void Main()
        {
            int num = 1000;
            string msg = "Message";
            Coordinate c = new Coordinate(21.0, 68.0);      //constructor

            Utils.Display(num);
            Utils.Display(msg);
            Utils.Display(c);
        }
    }
}
