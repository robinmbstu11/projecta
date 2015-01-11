using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    class ClassF : IInterfaceFtoA
    {
        private IInterfaceFtoA obFtoA;
        public ClassF(IInterfaceFtoA ob)
        {
            obFtoA = ob;
        }

        public void Method1()
        {
            obFtoA.MethodFtoA();
            obFtoA.MethodFtoA();
        }

        public void Method2()
        {
            obFtoA.MethodFtoA();
        }

        public void Method3()
        {
            obFtoA.MethodFtoA();
        }

        #region IInterfaceFtoA Members

        public void MethodFtoA()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
