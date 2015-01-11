using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassA 
    {
        IInterfaceE obAtoE;
        IInterfaceAtoY obAtoY;
        public ClassA(IInterfaceE ob)
        {
            obAtoE = ob;
        }

        public ClassA(IInterfaceAtoY ob)
        {
            obAtoY = ob;
        }

        public void Method1()
        {

        }

        public void Method2()
        {
            obAtoE.Method5();
            obAtoE.Method5();
        }

        public void Method3()
        {
            obAtoY.MethodAtoY();

        }

        #region IInterfaceE Members

        public void Method5()
        {
            throw new NotImplementedException();
        }

        #endregion
    
#region IInterfaceAtoY Members

public void MethodAtoY()
{
 	throw new NotImplementedException();
}

#endregion
}
}
 