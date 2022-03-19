using ComputerShopBusinessLogic.BusinessLogics;
using ComputerShopContracts.BusinessLogicsContracts;
using ComputerShopContracts.StoragesContracts;
using ComputerShopListImplement.Implements;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;



namespace ComputerShopView
{
    static class Program
    {
        private static IUnityContainer container = null;
        public static IUnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = BuildUnityContainer();
                }
                return container;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IComponentStorage,
            ComponentStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderStorage, OrderStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IComputerStorage, ProductStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType< ComponentLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType< OrderLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType< ComputerLogic>(new
            HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
