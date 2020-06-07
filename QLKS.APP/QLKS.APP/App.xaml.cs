using QLKS.APP.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using Prism.Events;
using QLKS.Auth;
using QLKS.Auth.Events;
using System;

namespace QLKS.APP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected IEventAggregator EventAggregator { get; private set; }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        protected override void OnInitialized()
        {
            //var session = Container.Resolve<IModuleInitializationSession>();
            ShowLoginForm();
        }
        //private void RaiseInitializingEvents(string state)
        //{
        //    EventAggregator.GetEvent<ApplicationInitializingEvent>().Publish(state);
        //    Log.Debug(state);
        //    Thread.Sleep(100);
        //}
        private void ShowLoginForm()
        {
            var loginForm = Container.Resolve<ILoginForm>();
            //EventAggregator.GetEvent<LoginSucceededEvent>().Subscribe(() =>
            //{
            //    loginForm.Close();
            //    ShowMainWindow();
            //}, ThreadOption.PublisherThread, true);
            loginForm.Show();
        }

        private void ShowMainWindow()
        {
            //using (var session = Container.Resolve<IModuleInitializationSession>())
            //{
            //    RaiseInitializingEvents("Registering View Components");
            //    session.Apply(module =>
            //        module.RegisterRibbon(Container.Resolve<IRibbonRegistry>(), Container));

            //    RaiseInitializingEvents("Registering Regions");
            //    session.Apply(module =>
            //        module.RegisterRegions(Container.Resolve<IRegionManager>(), Container));
            //}

            //MainWindow?.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog() { ModulePath = @".\" };
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            //var customPrincipal = new UserPrincipal();
            //AppDomain.CurrentDomain.SetThreadPrincipal(customPrincipal);
            base.OnStartup(e);
        }
    }
}
