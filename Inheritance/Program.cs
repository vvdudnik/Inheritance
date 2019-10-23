using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] values =             { { 1, 2,3},
                                        {4,5,6 }};

            int l = values.Length;
            int l1 = values.GetLength(0);
            int l2 = values.GetLength(1);
            Class1 c1 = new Class1();
            Class1 c2 = new Class2();
            Class1 c3 = new Class3();
            Class1 c4 = new Class4();

            c1.Method1();
            c1.Method2();
            Console.WriteLine();
            c2.Method1();
            c2.Method2();
            Console.WriteLine();

            c3.Method1();
            c3.Method2();
            Console.WriteLine();

            c4.Method1();
            c4.Method2();
            Console.ReadLine();
        }
    }
}
