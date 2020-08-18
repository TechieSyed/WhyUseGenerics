using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyUseGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Swap(ref a, ref b);
            Console.WriteLine("a={0}, b={1}", a, b);

            bool b1 = true, b2 = false;
            Swap(ref b1, ref b2);
            Console.WriteLine("b1={0}, b2={1}", b1, b2);
            Console.ReadKey();
        }
        static void Swap(ref int i, ref int j)
        {
            int k = i;
            i = j;
            j = k;
        }
        static void Swap(ref bool b, ref bool b1)
        {
            bool temp = b;
            b = b1;
            b1 = temp;
        }
    }
}
