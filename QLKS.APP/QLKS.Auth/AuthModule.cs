using QLKS.Auth.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace QLKS.Auth
{
    public class AuthModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ILoginForm, LoginForm>();
        }
    }
}