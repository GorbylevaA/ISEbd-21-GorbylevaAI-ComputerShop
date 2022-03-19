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
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using (var context = new ComputerShopDatabase())
            {
                return context.Orders
                    .Select(rec => new OrderViewModel
                    {
                        Id = rec.Id,
                        ComputerId = rec.ComputerId,
                        ComputerName = context.Computers.Include(pr => pr.Orders).FirstOrDefault(pr => pr.Id == rec.ComputerId).ComputerName,
                        Count = rec.Count,
                        Sum = rec.Sum,
                        Status = rec.Status,
                        DateCreate = rec.DateCreate,
                        DateImplement = rec.DateImplement,
                    })
                    .ToList();
            }
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new ComputerShopDatabase())
            {
                return context.Orders
                    .Where(rec => rec.ComputerId == model.ComputerId)
                    .Select(rec => new OrderViewModel
                    {
                        Id = rec.Id,
                        ComputerId = rec.ComputerId,
                        ComputerName = context.Computers.Include(pr => pr.Orders).FirstOrDefault(pr => pr.Id == rec.ComputerId).ComputerName,
                        Count = rec.Count,
                        Sum = rec.Sum,
                        Status = rec.Status,
                        DateCreate = rec.DateCreate,
                        DateImplement = rec.DateImplement,
                    })
                    .ToList();
            }
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new ComputerShopDatabase())
            {
                Order order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                return order != null ?
                new OrderViewModel
                {
                    Id = order.Id,
                    ComputerId = order.ComputerId,
                    ComputerName = context.Computers.Include(pr => pr.Orders).FirstOrDefault(rec => rec.Id == order.ComputerId)?.ComputerName,
                    Count = order.Count,
                    Sum = order.Sum,
                    Status = order.Status,
                    DateCreate = order.DateCreate,
                    DateImplement = order.DateImplement,
                } :
                null;
            }
        }

        public void Insert(OrderBindingModel model)
        {
            using (var context = new ComputerShopDatabase())
            {
                var order = new Order
                {
                    ComputerId = model.ComputerId,
                    Count = model.Count,
                    Sum = model.Sum,
                    Status = model.Status,
                    DateCreate = model.DateCreate,
                    DateImplement = model.DateImplement,
                };
                context.Orders.Add(order);
                context.SaveChanges();
                CreateModel(model, order);
                context.SaveChanges();
            }
        }

        public void Update(OrderBindingModel model)
        {
            using (var context = new ComputerShopDatabase())
            {
                Order order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (order == null)
                {
                    throw new Exception("Элемент не найден");
                }
                order.ComputerId = model.ComputerId;
                order.Count = model.Count;
                order.Sum = model.Sum;
                order.Status = model.Status;
                order.DateCreate = model.DateCreate;
                order.DateImplement = model.DateImplement;

                CreateModel(model, order);
                context.SaveChanges();
            }
        }

        public void Delete(OrderBindingModel model)
        {
            using (var context = new ComputerShopDatabase())
            {
                Order order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Order CreateModel(OrderBindingModel model, Order order)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new ComputerShopDatabase())
            {
                Computer computer = context.Computers.FirstOrDefault(rec => rec.Id == model.ComputerId);
                if (computer != null)
                {
                    if (computer.Orders == null)
                    {
                        computer.Orders = new List<Order>();
                    }

                    computer.Orders.Add(order);
                    context.Computers.Update(computer);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
            return order;
        }
    }
}