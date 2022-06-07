using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ComputerShopContracts.ViewModels
{
    public class WareHouseViewModel
    {
        public int? Id { get; set; }

        [DisplayName("Название склада")]
        public string WareHouseName { get; set; }

        [DisplayName("ФИО ответственного")]
        public string ResponsiblePersonFIO { get; set; }

        [DisplayName("Дата создания склада")]
        public DateTime DateCreate { get; set; }

        public Dictionary<int, (string, int)> WareHouseComponents { get; set; } 
    }
}
