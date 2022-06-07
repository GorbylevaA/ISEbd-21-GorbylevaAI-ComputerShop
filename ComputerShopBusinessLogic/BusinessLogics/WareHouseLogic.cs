using ComputerShopContracts.BindingModels;
using ComputerShopContracts.BusinessLogicsContracts;
using ComputerShopContracts.StoragesContracts;
using ComputerShopContracts.ViewModels;
using System;
using System.Collections.Generic;

namespace ComputerShopBusinessLogic.BusinessLogics
{
    public class WareHouseLogic : IWareHouseLogic
    {
        private readonly IWareHouseStorage _wareHouseStorage;

        private readonly IComponentStorage _componentStorage;

        public WareHouseLogic(IWareHouseStorage wareHouseStorage, IComponentStorage componentsStorage)
        {
            _wareHouseStorage = wareHouseStorage;
            _componentStorage = componentsStorage;
        }

        public List<WareHouseViewModel> Read(WareHouseBindingModel model)
        {
            if (model == null)
            {
                return _wareHouseStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<WareHouseViewModel> { _wareHouseStorage.GetElement(model) };
            }
            return _wareHouseStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(WareHouseBindingModel model)
        {
            var element = _wareHouseStorage.GetElement(new WareHouseBindingModel
            {
                WareHouseName = model.WareHouseName
            });
            if (element != null && element.WareHouseName != model.WareHouseName)
            {
                throw new Exception("Уже есть склад с таким названием");
            }
            if (model.Id.HasValue)
            {
                _wareHouseStorage.Update(model);
            }
            else
            {
                _wareHouseStorage.Insert(model);
            }
        }

        public void Delete(WareHouseBindingModel model)
        {
            var element = _wareHouseStorage.GetElement(new WareHouseBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _wareHouseStorage.Delete(model);
        }

        public void ReplenishByComponent(WareHouseReplenishmentBindingModel model)
        {
            var wareHouse = _wareHouseStorage.GetElement(new WareHouseBindingModel
            {
                Id = model.WareHouseId
            });
            if (wareHouse == null)
            {
                throw new Exception("Не найден склад");
            }
            var component = _componentStorage.GetElement(new ComponentBindingModel
            {
                Id = model.ComponentId
            });
            if (component == null)
            {
                throw new Exception("Не найден компонент");
            }
            if (wareHouse.WareHouseComponents.ContainsKey(model.ComponentId))
            {
                wareHouse.WareHouseComponents[model.ComponentId] =
                (component.ComponentName, wareHouse.WareHouseComponents[model.ComponentId].Item2 + model.Count);
            }
            else
            {
                wareHouse.WareHouseComponents.Add(component.Id, (component.ComponentName, model.Count));
            }
            _wareHouseStorage.Update(new WareHouseBindingModel
            {
                Id = wareHouse.Id,
                WareHouseName = wareHouse.WareHouseName,
                ResponsiblePersonFIO = wareHouse.ResponsiblePersonFIO,
                DateCreate = wareHouse.DateCreate,
                WareHouseComponents = wareHouse.WareHouseComponents
            });
        }
    }
}