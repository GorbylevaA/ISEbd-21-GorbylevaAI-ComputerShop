using ComputerShopContracts.BindingModels;
using ComputerShopContracts.ViewModels;
using System.Collections.Generic;

namespace ComputerShopContracts.BusinessLogicsContracts
{
    public interface IComponentLogic
    {
        List<ComponentViewModel> Read(ComponentBindingModel model);

        void CreateOrUpdate(ComponentBindingModel model);

        void Delete(ComponentBindingModel model);
    }
}
