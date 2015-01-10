using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassJ : IInterface_pak2
    {
        IInterface_pak2 ob3;
        public ClassJ(IInterface_pak2 ob)
        {
            ob3 = ob;
        }
        public void Method1()
        {
            ob3.Method15();
        }

        #region IInterface_pak2 Members

        public void Method15()
        {

        }

        #endregion
    }
}
