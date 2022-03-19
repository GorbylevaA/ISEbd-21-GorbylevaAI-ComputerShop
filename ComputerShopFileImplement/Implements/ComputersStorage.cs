using ComputerShopContracts.BindingModels;
using ComputerShopContracts.StoragesContracts;
using ComputerShopContracts.ViewModels;
using ComputerShopFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerShopFileImplement.Implements
{
    public class ComputersStorage : IComputerStorage
    {
        private readonly FileDataListSingleton source;

        public ComputersStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }

        public List<ComputerViewModel> GetFullList()
        {
            return source.Computers
                .Select(CreateModel)
                .ToList();
        }

        public List<ComputerViewModel> GetFilteredList(ComputerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.Computers
                .Where(recComputer => recComputer.ComputerName.Contains(model.ComputerName))
                .Select(CreateModel)
                .ToList();
        }

        public ComputerViewModel GetElement(ComputerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            Computer computer = source.Computers.FirstOrDefault(recComputer => recComputer.ComputerName == model.ComputerName || recComputer.Id == model.Id);
            return computer != null ? CreateModel(computer) : null;
        }

        public void Insert(ComputerBindingModel model)
        {
            int maxId = source.Computers.Count > 0 ? source.Computers.Max(recComputer => recComputer.Id) : 0;
            var computer = new Computer
            {
                Id = maxId + 1,
                ComputerComponents = new Dictionary<int, int>()
            };
            source.Computers.Add(CreateModel(model, computer));
        }

        public void Update(ComputerBindingModel model)
        {
            Computer computer = source.Computers.FirstOrDefault(recComputer => recComputer.Id == model.Id);
            if (computer == null)
            {
                throw new Exception("Компьютер не найден");
            }
            CreateModel(model, computer);
        }

        public void Delete(ComputerBindingModel model)
        {
            Computer computer = source.Computers.FirstOrDefault(recComputer => recComputer.Id == model.Id);
            if (computer != null)
            {
                source.Computers.Remove(computer);
            }
            else
            {
                throw new Exception("Компьютер не найден");
            }
        }

        private Computer CreateModel(ComputerBindingModel model, Computer computer)
        {
            computer.ComputerName = model.ComputerName;
            computer.Price = model.Price;

            foreach (var key in computer.ComputerComponents.Keys.ToList())
            {
                if (!model.ComputerComponents.ContainsKey(key))
                {
                    computer.ComputerComponents.Remove(key);
                }
            }

            foreach (var component in model.ComputerComponents)
            {
                if (computer.ComputerComponents.ContainsKey(component.Key))
                {
                    computer.ComputerComponents[component.Key] = model.ComputerComponents[component.Key].Item2;
                }
                else
                {
                    computer.ComputerComponents.Add(component.Key, model.ComputerComponents[component.Key].Item2);
                }
            }
            return computer;
        }

        private ComputerViewModel CreateModel(Computer computer)
        {
            return new ComputerViewModel
            {
                Id = computer.Id,
                ComputerName = computer.ComputerName,
                Price = computer.Price,
                ComputerComponents = computer.ComputerComponents
                .ToDictionary(computerComponents => computerComponents.Key, computerComponent =>
                (source.Components.FirstOrDefault(Component => Component.Id == computerComponent.Key)?.ComponentName, computerComponent.Value))
            };
        }
    }
}
