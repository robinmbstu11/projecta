using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassC : IInterfaceVtoC
    {
        internal void Method1()
        {
            
        }
        #region IInterfaceVtoC Members

        public void MethodVtoC()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
