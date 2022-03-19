using ComputerShopContracts.BindingModels;
using ComputerShopContracts.StoragesContracts;
using ComputerShopContracts.ViewModels;
using ComputerShopListImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerShopListImplement.Implements
{
    public class ComputersStorage : IComputerStorage
    {
        private readonly DataListSingleton source;

        public ComputersStorage()
        {
            source = DataListSingleton.GetInstance();
        }

        public List<ComputerViewModel> GetFullList()
        {
            List<ComputerViewModel> result = new List<ComputerViewModel>();
            foreach (var computer in source.Computers)
            {
                result.Add(CreateModel(computer));
            }
            return result;
        }

        public List<ComputerViewModel> GetFilteredList(ComputerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            List<ComputerViewModel> result = new List<ComputerViewModel>();
            foreach (var computer in source.Computers)
            {
                if (computer.ComputerName.Contains(model.ComputerName))
                {
                    result.Add(CreateModel(computer));
                }
            }
            return result;
        }

        public ComputerViewModel GetElement(ComputerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var computer in source.Computers)
            {
                if (computer.Id == model.Id || computer.ComputerName ==
                model.ComputerName)
                {
                    return CreateModel(computer);
                }
            }
            return null;
        }

        public void Insert(ComputerBindingModel model)
        {
            Computer tempComputer = new Computer
            {
                Id = 1,
                ComputerComponents = new
            Dictionary<int, int>()
            };
            foreach (var computer in source.Computers)
            {
                if (computer.Id >= tempComputer.Id)
                {
                    tempComputer.Id = computer.Id + 1;
                }
            }
            source.Computers.Add(CreateModel(model, tempComputer));
        }

        public void Update(ComputerBindingModel model)
        {
            Computer tempComputer = null;
            foreach (var computer in source.Computers)
            {
                if (computer.Id == model.Id)
                {
                    tempComputer = computer;
                }
            }
            if (tempComputer == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempComputer);
        }

        public void Delete(ComputerBindingModel model)
        {
            for (int i = 0; i < source.Computers.Count; ++i)
            {
                if (source.Computers[i].Id == model.Id)
                {
                    source.Computers.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }

        private static Computer CreateModel(ComputerBindingModel model, Computer
        computer)
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
            foreach (var computers in model.ComputerComponents)
            {
                if (computer.ComputerComponents.ContainsKey(computers.Key))
                {
                    computer.ComputerComponents[computers.Key] =
                    model.ComputerComponents[computers.Key].Item2;
                }
                else
                {
                    computer.ComputerComponents.Add(computers.Key,
                    model.ComputerComponents[computers.Key].Item2);
                }
            }
            return computer;
        }

        private ComputerViewModel CreateModel(Computer computer)
        {
            Dictionary<int, (string, int)> ComputerComponents = new
            Dictionary<int, (string, int)>();

            foreach (var pc in computer.ComputerComponents)
            {
                string computerName = string.Empty;
                foreach (var computers in source.Computers)
                {
                    if (pc.Key == computers.Id)
                    {
                        computerName = computers.ComputerName;
                        break;
                    }
                }
                ComputerComponents.Add(pc.Key, (computerName, pc.Value));
            }
            return new ComputerViewModel
            {
                Id = computer.Id,
                ComputerName = computer.ComputerName,
                Price = computer.Price,
                ComputerComponents = ComputerComponents
            };
        }
    }
}
