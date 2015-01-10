using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassZ
    {
        private IInterface_pak2 ob8;
        public ClassZ(IInterface_pak2 ob)
        {
            ob8 = ob;
        }
        public void Method2()
        {
            ob8.Method15();
            ob8.Method15();
        }
    }
}
