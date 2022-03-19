using ComputerShopContracts.BindingModels;
using ComputerShopContracts.ViewModels;
using System.Collections.Generic;

namespace ComputerShopContracts.BusinessLogicsContracts
{
    public interface IComputerLogic
    {
        List<ComputerViewModel> Read(ComputerBindingModel model);

        void CreateOrUpdate(ComputerBindingModel model);

        void Delete(ComputerBindingModel model);
    }
}
