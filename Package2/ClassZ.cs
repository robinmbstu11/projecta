using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassZ
    {
        private IInterfaceZtoJ obztoj;
        private IInterfaceZtoQ obztoq;
        public ClassZ(IInterfaceZtoJ ob)
        {
            obztoj = ob;
        }
        public ClassZ(IInterfaceZtoQ ob)
        {
            obztoq = ob;
        }
        public void Method2()
        {
            obztoj.MethodZtoJ();
            obztoq.MethodZtoQ();
        }
    }
}
