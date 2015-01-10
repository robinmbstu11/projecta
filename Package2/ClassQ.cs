using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassQ : IInterface_pak2
    {
        private IInterface_pak2 ob6;
        public ClassQ(IInterface_pak2 ob)
        {
            ob6 = ob;
        }
        public void Method3()
        {
            ob6.Method15();
        }

        #region IInterface_pak2 Members

        public void Method15()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
