using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassH
    {
        private IInterfaceHtoG obhtog;
        public ClassH(IInterfaceHtoG ob)
        {
            obhtog = ob;
        }
        public void Method2()
        {
           
            obhtog.MethodHtoG();
        }
    }
}
