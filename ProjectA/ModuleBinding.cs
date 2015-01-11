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
            Kernel.Bind<IInterfaceAtoY>().To<ClassY>();
            Kernel.Bind<IInterfaceXtoR>().To<ClassR>();
            Kernel.Bind<IInterfaceDtoA>().To<ClassA>();

            Kernel.Bind<IInterface_pak2>().To<ClassK>();
            Kernel.Bind<IInterfaceOtoT>().To<ClassT>();

            Kernel.Bind<IInterfaceXtoR>().To<ClassR>();

            Kernel.Bind<IInterfaceQtoJ>().To<ClassJ>();
            Kernel.Bind<IInterfaceVtoC>().To<ClassC>();
            Kernel.Bind<IInterfaceZtoJ>().To<ClassJ>();
            Kernel.Bind<IInterfaceZtoQ>().To<ClassQ>();

            Kernel.Bind<IInterfaceHtoG>().To<ClassG>();
        }
    }
}
