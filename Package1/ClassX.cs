using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassX
    {
        IInterfaceE ob1;
        public ClassX(IInterfaceE ob)
        {
            ob1 = ob;
        }
        public void Method1()
        {
            ob1.Method5();
        }
    }
}
