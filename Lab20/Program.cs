using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate1 = Method1;
            Console.WriteLine(myDelegate1(10));
            MyDelegate myDelegate2 = Method2;
            Console.WriteLine(myDelegate2(10));
            MyDelegate myDelegate3 = Method3;
            Console.WriteLine(myDelegate3(10));
            Console.ReadKey();
        }
        static double Method1(double R)
        {
            return 2 * Math.PI * R;
        }
        static double Method2(double R)
        {
            return 2 * Math.PI * R * R;
        }
        static double Method3(double R)
        {
            return (4 / 3) * Math.PI * R * R * R;
        }
    }
}
