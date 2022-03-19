﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace AbstractShopContracts.ViewModels
{
    public class ComputerViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название компьютера")]
        public string ProductName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
      
        public Dictionary<int, (string, int)> ComputerComponents { get; set; }
        
    }
}
