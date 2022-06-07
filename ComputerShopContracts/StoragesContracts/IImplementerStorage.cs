using ComputerShopContracts.BindingModels;
using ComputerShopContracts.ViewModels;
using System.Collections.Generic;

namespace ComputerShopContracts.StoragesContracts
{
    public interface IImplementerStorage
    {
        List<ImplementerViewModel> GetFullList();

        List<ImplementerViewModel> GetFilteredList(ImplementerBindingModel model);

        ImplementerViewModel GetElement(ImplementerBindingModel model);

        void Insert(ImplementerBindingModel model);

        void Update(ImplementerBindingModel model);

        void Delete(ImplementerBindingModel model);
    }
}
