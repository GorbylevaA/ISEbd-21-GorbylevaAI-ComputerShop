using ComputerShopContracts.BindingModels;
using ComputerShopContracts.ViewModels;
using System.Collections.Generic;

namespace ComputerShopContracts.StoragesContracts
{
    public interface IWareHouseStorage
    {
        List<WareHouseViewModel> GetFullList();

        List<WareHouseViewModel> GetFilteredList(WareHouseBindingModel model);

        WareHouseViewModel GetElement(WareHouseBindingModel model);

        void Insert(WareHouseBindingModel model);

        void Update(WareHouseBindingModel model);

        void Delete(WareHouseBindingModel model);
    }
}
