using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassX : IInterfaceE
    {
        IInterfaceE ob1;
        public ClassX(IInterfaceE ob)
        {
            ob1 = ob;
        }
        public void Method1()
        {
            ob1.Method5();
        }

        #region IInterfaceE Members

        public void Method5()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
