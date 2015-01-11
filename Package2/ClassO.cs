using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassO
    {
        IInterfaceOtoT obOtoT;
        public ClassO(IInterfaceOtoT ob)
        {
            obOtoT = ob;
        }
        public void Method2()
        {
            obOtoT.MethodOtoT();
        }
    }
}
