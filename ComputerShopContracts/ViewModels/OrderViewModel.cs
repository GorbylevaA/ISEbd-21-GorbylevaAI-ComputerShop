﻿using ComputerShopContracts.Enums;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ComputerShopContracts.ViewModels
{
    [DataContract]
    public class OrderViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public int ComputerId { get; set; }

        [DataMember]
        [DisplayName("Клиент")]
        public string ClientFIO { get; set; }

        [DataMember]
        [DisplayName("Изделие")]
        public string ComputerName { get; set; }

        [DataMember]
        [DisplayName("Количество")]
        public int Count { get; set; }

        [DataMember]
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }

        [DataMember]
        [DisplayName("Статус")]
        public OrderStatus Status { get; set; }

        [DataMember]
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }

        [DataMember]
        [DisplayName("Дата выполнения")]
        public DateTime? DateImplement { get; set; }
    }
}
