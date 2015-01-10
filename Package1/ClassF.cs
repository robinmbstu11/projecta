using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    class ClassF
    {
        private ClassA _a;
        private IInterfaceE ob5;

        public ClassF(IInterfaceE ob)
        {
            ob5 = ob;
        }

        public void Method1()
        {
            ob5.Method5();
            ob5.Method5();
        }

        public void Method2()
        {
            ob5.Method5();
        }

        public void Method3()
        {
            ob5.Method5();
        }
    }
}
