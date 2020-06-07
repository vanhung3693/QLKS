using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;

namespace QLKS.APP
{
    public interface IModuleInitializationSession : IDisposable
    {
       // void Apply(Action<ModuleBase> action);
    }
}
