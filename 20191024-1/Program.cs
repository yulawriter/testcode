using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191024_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cale cale = new Cale();
            int s1 = cale.Add(3, 5);
            int s2 = cale.Sub(7, 2);
            int s3 = cale.MuL(9, 9);
            float s4 = cale.Div(7, 2);
            Console.WriteLine("3+5=" + s1);
            Console.WriteLine("7-2=" + s2);
            Console.WriteLine("7*2=" + s3);
            Console.WriteLine("7/2=" + s4);
            Console.ReadKey();
        }
    }
}
