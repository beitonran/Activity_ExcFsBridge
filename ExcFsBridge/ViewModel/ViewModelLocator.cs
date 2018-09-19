/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:ExcFsBridge.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using ExcFsBridge.Domain.Services.DeviceCollectService;
using Microsoft.Practices.ServiceLocation;
using ExcFsBridge.View.PageViews.HelpView;
using ExcFsBridge.View.ShellViews;
using ExcFsBridge.View.ShellViews.DeviceDataView;
using ExcFsBridge.Domain.Services.TaskService;
using ExcFsBridge.View.PageViews.TestView;
using ExcFsBridge.Domain.Services.SyncService;
using ExcFsBridge.View.ShellViews.FsuipcView;

namespace ExcFsBridge.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
           
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                //SimpleIoc.Default.Register<IDeviceScannerService, Design.DesignDataService>();
            }
            else
            {
                //SimpleIoc.Default.Register<IDeviceScannerService, DeviceScannerService>();
                SimpleIoc.Default.Register<IDataCollectSrv, DataCollectSrv>();
                SimpleIoc.Default.Register<IDBSrv, DBSrv>();
                SimpleIoc.Default.Register<ITaskSrv, TaskSrv>();
                SimpleIoc.Default.Register<IAsyncSrv, AsyncSrv>();
                SimpleIoc.Default.Register<ISyncSrv, SyncSrv>();

            }


            //SimpleIoc.Default.Register<IDeviceInfoRepository>(() => new DeviceInfoRepository("devconfig"), "devices", true);


            SetupNavigation();
            SimpleIoc.Default.Register<ShellViewModel>();
            SimpleIoc.Default.Register<HelpViewModel>();
            SimpleIoc.Default.Register<TestViewModel>();
            SimpleIoc.Default.Register<ShellViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();


            SimpleIoc.Default.Register<FileExportSettingsViewModel>();
            SimpleIoc.Default.Register<StartViewModelFsBridge>();



        }

        private static void SetupNavigation()
        {
            var navigationService = new FrameNavigationService();
            navigationService.Configure("Shell", new Uri("../View/ShellViews/Shell.xaml", UriKind.Relative));
            navigationService.Configure("Help", new Uri("../View/PageViews/HelpView/HelpView.xaml", UriKind.Relative));
            navigationService.Configure("Test", new Uri("../View/PageViews/TestView/TestView.xaml", UriKind.Relative));
            navigationService.Configure("Config", new Uri("../View/PageViews/ConfigView/ConfigView.xaml", UriKind.Relative));

            SimpleIoc.Default.Register<IFrameNavigationService>(() => navigationService);

        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public HelpViewModel Help
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HelpViewModel>();
            }
        }
        public TestViewModel Test
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TestViewModel>();
            }
        }
        public FileExportSettingsViewModel FileExportSettings
        {
            get
            {
                return ServiceLocator.Current.GetInstance<FileExportSettingsViewModel>();
            }
        }
        public StartViewModelFsBridge StartViewFsBridge
        {
            get
            {
                return ServiceLocator.Current.GetInstance<StartViewModelFsBridge>();
            }
        }
        public ShellViewModel Shell
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ShellViewModel>();
            }
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}