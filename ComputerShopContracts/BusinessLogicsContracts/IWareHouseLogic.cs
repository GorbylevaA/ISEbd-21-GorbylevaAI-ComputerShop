using ComputerShopContracts.BindingModels;
using ComputerShopContracts.ViewModels;
using System.Collections.Generic;

namespace ComputerShopContracts.BusinessLogicsContracts
{
    public interface IWareHouseLogic
    {
        List<WareHouseViewModel> Read(WareHouseBindingModel model);

        void CreateOrUpdate(WareHouseBindingModel model);

        void Delete(WareHouseBindingModel model);

        void ReplenishByComponent(WareHouseReplenishmentBindingModel model);
    }
}
