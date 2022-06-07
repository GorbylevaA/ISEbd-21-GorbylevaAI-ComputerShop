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
        private readonly FileDataListSingleton _source;

        public OrderStorage()
        {
            _source = FileDataListSingleton.GetInstance();
        }

        public List<OrderViewModel> GetFullList()
        {
            return _source.Orders
                .Select(CreateModel)
                .ToList();
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            return _source.Orders
                .Where(rec => (!model.DateFrom.HasValue && !model.DateTo.HasValue && rec.DateCreate.Date == model.DateCreate.Date)
                || (model.DateFrom.HasValue && model.DateTo.HasValue && rec.DateCreate.Date >= model.DateFrom.Value.Date && rec.DateCreate.Date <= model.DateTo.Value.Date)
                || (model.ClientId.HasValue && rec.ClientId == model.ClientId)
                || (model.SearchStatus.HasValue && model.SearchStatus.Value == rec.Status)
                || (model.ImplementerId.HasValue && rec.ImplementerId == model.ImplementerId && model.Status == rec.Status))
                .Select(CreateModel)
                .ToList();
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            Order order = _source.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            return order != null ? CreateModel(order) : null;
        }

        public void Insert(OrderBindingModel model)
        {
            int maxId = _source.Orders.Count > 0 ? _source.Orders.Max(rec => rec.Id) : 0;
            var element = new Order { Id = maxId + 1 };
            _source.Orders.Add(CreateModel(model, element));
        }

        public void Update(OrderBindingModel model)
        {
            Order element = _source.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
        }

        public void Delete(OrderBindingModel model)
        {
            Order element = _source.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                _source.Orders.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.ClientId = (int)model.ClientId;
            order.ComputerId = model.ComputerId;
            order.Count = model.Count;
            order.Status = model.Status;
            order.Sum = model.Sum;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            order.ImplementerId = model.ImplementerId;
            return order;
        }

        private OrderViewModel CreateModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                ClientId = order.ClientId,
                ClientFIO = _source.Clients.FirstOrDefault(rec => rec.Id == order.ClientId)?.ClientFIO,
                ComputerId = order.ComputerId,
                ComputerName = _source.Computers.FirstOrDefault(p => p.Id == order.ComputerId)?.ComputerName,
                Count = order.Count,
                Status = order.Status,
                Sum = order.Sum,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement,
                ImplementerId = order.ImplementerId,
                ImplementerFIO = _source.Implementers.FirstOrDefault(x => x.Id == order.ImplementerId)?.ImplementerFIO
            };
        }
    }
}
