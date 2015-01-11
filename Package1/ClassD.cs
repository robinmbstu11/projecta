using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassD
    {
        
        private IInterfaceDtoA obDtoA;
        public ClassD(IInterfaceDtoA ob)
        {
            obDtoA = ob;
        }

        public void Method1()
        {
            obDtoA.MethodDtoA();
        }
    }
}
