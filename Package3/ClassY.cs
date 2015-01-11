using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package1;

namespace Package3
{
    public class ClassY : IInterfaceAtoY
    {
        public int Method2()
        {
            return 5;
        }

        #region IInterfaceAtoY Members

        public void MethodAtoY()
        {
            
        }

        #endregion
    }
}
