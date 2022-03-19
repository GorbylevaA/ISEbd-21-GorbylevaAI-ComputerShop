using Microsoft.EntityFrameworkCore;
using ComputerShopDatabaseImplement.Models;
using ComputerShopContracts.BindingModels;
using ComputerShopContracts.StoragesContracts;
using ComputerShopContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerShopDatabaseImplement.Implements
{
   public class ComputersStorage : IComputerStorage
    {
        public List<ComputerViewModel> GetFullList()
        {
            using (var context = new ComputerShopDatabase())
            {
                return context.Computers
                    .Include(rec => rec.ComputerComponents)
                    .ThenInclude(rec => rec.Component)
                    .ToList()
                    .Select(CreateModel)
                    .ToList();
            }
        }

        public List<ComputerViewModel> GetFilteredList(ComputerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new ComputerShopDatabase())
            {
                return context.Computers
                    .Include(rec => rec.ComputerComponents)
                    .ThenInclude(rec => rec.Component)
                    .Where(rec => rec.ComputerName.Contains(model.ComputerName))
                    .ToList()
                    .Select(CreateModel)
                    .ToList();
            }
        }

        public ComputerViewModel GetElement(ComputerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new ComputerShopDatabase())
            {
                Computer computer = context.Computers
                    .Include(rec => rec.ComputerComponents)
                    .ThenInclude(rec => rec.Component)
                    .FirstOrDefault(rec => rec.ComputerName == model.ComputerName || rec.Id == model.Id);

                return computer != null ? CreateModel(computer) : null;
            }
        }

        public void Insert(ComputerBindingModel model)
        {
            using (var context = new ComputerShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var computer = new Computer
                        {
                            ComputerName = model.ComputerName,
                            Price = model.Price
                        };
                        context.Computers.Add(computer);
                        context.SaveChanges();

                        CreateModel(model, computer, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Update(ComputerBindingModel model)
        {
            using (var context = new ComputerShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Computer computer = context.Computers.FirstOrDefault(rec => rec.Id == model.Id);
                        if (computer == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        computer.ComputerName = model.ComputerName;
                        computer.Price = model.Price;

                        CreateModel(model, computer, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Delete(ComputerBindingModel model)
        {
            using (var context = new ComputerShopDatabase())
            {
                Computer computer = context.Computers.FirstOrDefault(rec => rec.Id == model.Id);
                if (computer != null)
                {
                    context.Computers.Remove(computer);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private static Computer CreateModel(ComputerBindingModel model, Computer computer, ComputerShopDatabase context)
        {
            if (model.Id.HasValue)
            {
                var computerComponents = context.ComputerComponents.Where(rec => rec.ComputerId == model.Id.Value).ToList();
                context.ComputerComponents.RemoveRange(computerComponents.Where(rec => !model.ComputerComponents.ContainsKey(rec.ComponentId)).ToList());
                context.SaveChanges();
                foreach (var updateComponent in computerComponents)
                {
                    updateComponent.Count = model.ComputerComponents[updateComponent.ComponentId].Item2;
                    model.ComputerComponents.Remove(updateComponent.ComponentId);
                }
                context.SaveChanges();
            }

            foreach (var pc in model.ComputerComponents)
            {
                context.ComputerComponents.Add(new ComputerComponent
                {
                    ComputerId = computer.Id,
                    ComponentId = pc.Key,
                    Count = pc.Value.Item2
                });

                context.SaveChanges();
            }

            return computer;
        }

        private static ComputerViewModel CreateModel(Computer computer)
        {
            return new ComputerViewModel
            {
                Id = computer.Id,
               ComputerName = computer.ComputerName,
                Price = computer.Price,
                ComputerComponents = computer.ComputerComponents
                .ToDictionary(recPC => recPC.ComponentId, recPC => (recPC.Component?.ComponentName, recPC.Count))
            };
        }
    }
}
