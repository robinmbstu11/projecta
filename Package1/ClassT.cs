﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package2;

namespace Package1
{
    public class ClassT : IInterfaceOtoT
    {
        private IInterfaceE _ie;

        public ClassT(IInterfaceE ie)
        {
            _ie = ie;
        }

        public void Method2()
        {
            _ie.Method5();
        }

        #region IInterfaceOtoT Members

        public void MethodOtoT()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
