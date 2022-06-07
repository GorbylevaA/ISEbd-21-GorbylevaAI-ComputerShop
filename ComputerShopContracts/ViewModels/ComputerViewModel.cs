using ComputerShopContracts.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ComputerShopContracts.ViewModels
{
    [DataContract]
    public class ComputerViewModel
    {
        [Column(title: "Номер", width: 100)]
        [DataMember]
        public int Id { get; set; }

        [Column(title: "Компьютер", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        [DisplayName("Название компьютера")]
        public string ComputerName { get; set; }

        [Column(title: "Цена", width: 50)]
        [DataMember]
        [DisplayName("Цена")]
        public decimal Price { get; set; }

        [DataMember]
        public Dictionary<int, (string, int)> ComputerComponents { get; set; }
    }
}
