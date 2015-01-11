using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassV 
    {
        private IInterfaceVtoC ob7;
        public ClassV(IInterfaceVtoC ob)
        {
            ob7 = ob;
        }
        public void Method2()
        {
       
            ob7.MethodVtoC();
        }
    }
}
