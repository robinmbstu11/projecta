using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassX
    {
        IInterfaceXtoR obXtoR;
        public ClassX(IInterfaceXtoR ob)
        {
            obXtoR = ob;
        }
        public void Method1()
        {
            obXtoR.MethodXtoR();
        }

        #region IInterfaceXtoR Members

        public void MethodXtoR()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

       