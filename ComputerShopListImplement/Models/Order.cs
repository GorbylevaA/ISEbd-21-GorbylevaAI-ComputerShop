﻿using ComputerShopContracts.Enums;
using System;

namespace ComputerShopListImplement.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int ComputerId { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }

        public OrderStatus Status { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime? DateImplement { get; set; }
    }
}
