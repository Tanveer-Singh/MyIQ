using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testt
{
    public class A
    {

        public void PrintMe()
        {
            Console.WriteLine("Printing");
        }
    }


    public class B : A
    {
        public void PrintMe()
        {
            Console.WriteLine("Check");
        }

        public void PrintMe(string a)
        {
            Console.WriteLine("Printging");
        }
 
    }

    public class Program
    {
        static void Main(string[] args)
        {

            B ob = new B();
        }
    }
}
