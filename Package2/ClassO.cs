using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassO
    {
        IInterface_pak2 ob4;
        public ClassO(IInterface_pak2 ob)
        {
            ob4 = ob;
        }
        public void Method2()
        {
            ob4.Method15();
        }
    }
}
