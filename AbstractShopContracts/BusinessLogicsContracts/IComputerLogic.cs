using System;
using System.Collections.Generic;
using System.Text;
using AbstractShopContracts.BindingModels;
using AbstractShopContracts.ViewModels;

namespace AbstractShopContracts.BusinessLogicsContracts
{
    public interface IComputerLogic
    {
        List<ComputerViewModel> Read(ComputerBindingModel model);
        void CreateOrUpdate(ComputerBindingModel model);
        void Delete(ComputerBindingModel model);

    }
}
