using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Package1;
using Package3;
using Package2;

namespace ProjectA
{
    public class ModuleBinding : NinjectModule
    { 
        public override void Load()
        {
            Kernel.Bind<IInterfaceE>().To<ClassS>();
            Kernel.Bind<IInterfaceE>().To<ClassY>();
            Kernel.Bind<IInterfaceE>().To<ClassR>();

            Kernel.Bind<IInterface_pak2>().To<ClassK>();
            Kernel.Bind<IInterface_pak2>().To<ClassT>();

            Kernel.Bind<IInterfaceE>().To<ClassX>();

            Kernel.Bind<IInterface_pak2>().To<ClassJ>();
            Kernel.Bind<IInterface_pak2>().To<ClassC>();
            Kernel.Bind<IInterface_pak2>().To<ClassQ>();


        }
    }
}
