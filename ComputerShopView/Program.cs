using ComputerShopListImplement.Implements;
using ComputerShopBusinessLogic.BusinessLogics;
using ComputerShopContracts.BusinessLogicsContracts;
using ComputerShopContracts.StoragesContracts;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;



namespace ComputerShopView
{
    static class Program
    {
    
    
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IComponentStorage, ComponentStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderStorage, OrderStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWareHouseStorage, WareHouseStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IComputerStorage, ProductStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IComponentLogic, ComponentLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderLogic, OrderLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IComputerLogic, ComputerLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWareHouseLogic, WareHouseLogic>(new
            HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
