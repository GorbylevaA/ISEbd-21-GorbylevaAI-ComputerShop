﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShopContracts.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int ComputerId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
    }
}
