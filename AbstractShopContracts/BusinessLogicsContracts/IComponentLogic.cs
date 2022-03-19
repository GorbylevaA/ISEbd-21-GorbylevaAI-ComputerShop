using System;
using System.Collections.Generic;
using System.Text;
using AbstractShopContracts.BindingModels;
using AbstractShopContracts.ViewModels;

namespace AbstractShopContracts.BusinessLogicsContracts
{
    public interface IComponentLogic
    {
        List<ComponentViewModel> Read(ComponentBindingModel model);
        void CreateOrUpdate(ComponentBindingModel model);
        void Delete(ComponentBindingModel model);

    }
}
