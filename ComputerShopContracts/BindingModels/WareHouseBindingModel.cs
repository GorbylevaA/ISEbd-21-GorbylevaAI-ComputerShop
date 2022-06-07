﻿using System;
using System.Collections.Generic;


namespace ComputerShopContracts.BindingModels
{
    public class WareHouseBindingModel
    {
        public int? Id { get; set; }

        public string WareHouseName { get; set; }

        public string ResponsiblePersonFIO { get; set; }

        public DateTime DateCreate { get; set; }

        public Dictionary<int, (string, int)> WareHouseComponents { get; set; } 
    }
}
