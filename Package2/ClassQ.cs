using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassQ :IInterfaceZtoJ,IInterfaceZtoQ
    {
        private IInterfaceQtoJ obQtoJ;
        public ClassQ(IInterfaceQtoJ ob)
        {
            obQtoJ = ob;
        }
        public void Method3()
        {
            obQtoJ.MethodQtoJ();
        }

        #region IInterfaceZtoJ Members

        public void MethodZtoJ()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IInterfaceZtoQ Members

        public void MethodZtoQ()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
