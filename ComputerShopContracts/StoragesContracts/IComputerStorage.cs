using System;
using System.Collections.Generic;
using System.Text;
using ComputerShopContracts.BindingModels;
using ComputerShopContracts.ViewModels;

namespace ComputerShopContracts.StoragesContracts
{
    public interface IComputerStorage
    {
        List<ComputerViewModel> GetFullList();
        List<ComputerViewModel> GetFilteredList(ComputerBindingModel model);
        ComputerViewModel GetElement(ComputerBindingModel model);
        void Insert(ComputerBindingModel model);
        void Update(ComputerBindingModel model);
        void Delete(ComputerBindingModel model);
    }
}
