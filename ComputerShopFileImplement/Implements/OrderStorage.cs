﻿using ComputerShopContracts.BindingModels;
using ComputerShopContracts.StoragesContracts;
using ComputerShopContracts.ViewModels;
using ComputerShopFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerShopFileImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        private readonly FileDataListSingleton source;

        public OrderStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }

        public List<OrderViewModel> GetFullList()
        {
            return source.Orders
                .Select(CreateModel)
                .ToList();
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            return source.Orders
                .Where(recOrder => recOrder.ComputerId == model.ComputerId)
                .Select(CreateModel)
                .ToList();
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            Order order = source.Orders.FirstOrDefault(recOder => recOder.Id == model.Id);
            return order != null ? CreateModel(order) : null;
        }

        public void Insert(OrderBindingModel model)
        {
            int maxId = source.Orders.Count > 0 ? source.Orders.Max(recOder => recOder.Id) : 0;
            var order = new Order { Id = maxId + 1 };
            source.Orders.Add(CreateModel(model, order));
        }

        public void Update(OrderBindingModel model)
        {
            Order order = source.Orders.FirstOrDefault(recOder => recOder.Id == model.Id);
            if (order == null)
            {
                throw new Exception("Заказ не найден");
            }
            CreateModel(model, order);
        }

        public void Delete(OrderBindingModel model)
        {
            Order order = source.Orders.FirstOrDefault(recOrder => recOrder.Id == model.Id);
            if (order != null)
            {
                source.Orders.Remove(order);
            }
            else
            {
                throw new Exception("Заказ не найден");
            }
        }

        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.ComputerId = model.ComputerId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }

        private OrderViewModel CreateModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                ComputerName = source.Computers.FirstOrDefault(computer => computer.Id == order.ComputerId)?.ComputerName,
                ComputerId = order.ComputerId,
                Count = order.Count,
                Sum = order.Sum,
                Status = order.Status,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement
            };
        }
    }
}
