using System;
using System.Collections.Generic;
using System.Text;
using ComputerShopContracts.BindingModels;
using ComputerShopContracts.ViewModels;

namespace ComputerShopContracts.BusinessLogicsContracts
{
    public interface IComputerLogic
    {
        List<ComputerViewModel> Read(ComputerBindingModel model);
        void CreateOrUpdate(ComputerBindingModel model);
        void Delete(ComputerBindingModel model);

    }
}
