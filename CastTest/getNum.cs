using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastTest
{
    internal class getNum
    {
        public  int getnumber()
        {
            String num = Console.ReadLine();
            if (num == null)
            {
                Console.WriteLine("Default number is 77");
                return 7;
            }
            else 
            {
                int number = Convert.ToInt32(num);
                return number;
            }

        }
    }
}
