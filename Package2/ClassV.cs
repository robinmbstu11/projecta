using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassV
    {
        private IInterface_pak2 ob7;
        public ClassV(IInterface_pak2 ob)
        {
            ob7 = ob;
        }
        public void Method2()
        {
       
            ob7.Method15();
        }
    }
}
