using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassA
    {
        IInterfaceE ob1,ob2;
        public ClassA(IInterfaceE ob)
        {
            ob1 = ob;
            ob2 = ob;
        }
        public void Method1()
        {

        }

        public void Method2()
        {
            ob1.Method5();
            ob1.Method5();
        }

        public void Method3()
        {
            ob2.Method5();

        }
    }
}
 