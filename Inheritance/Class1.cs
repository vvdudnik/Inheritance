using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Class1
    {
        public virtual void Method1()
        {
            Console.WriteLine("Method1 from class1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Method2 from class1");
        }
    }

    class Class2:Class1
    {
        public override void Method1()
        {
            Console.WriteLine("Method1 from class2");
        }

        public override void Method2()
        {
            Console.WriteLine("Method2 from class2");
        }
    }
    class Class3:Class2
    {
        public override void Method1()
        {
            Console.WriteLine("Method1 from class3");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Method2 from class3");
        }
    }
    class Class4:Class3
    {
        public override void Method1()
        {
            Console.WriteLine("Method1 from class4");
        }

        public override void Method2()
        {
            Console.WriteLine("Method2 from class4");
        }
    }

}
