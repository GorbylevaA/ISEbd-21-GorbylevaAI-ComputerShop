using System;
using System.Collections.Generic;
using System.Text;
using ComputerShopContracts.BindingModels;
using ComputerShopContracts.ViewModels;

namespace ComputerShopContracts.BusinessLogicsContracts
{
    public interface IComponentLogic
    {
        List<ComponentViewModel> Read(ComponentBindingModel model);
        void CreateOrUpdate(ComponentBindingModel model);
        void Delete(ComponentBindingModel model);

    }
}
