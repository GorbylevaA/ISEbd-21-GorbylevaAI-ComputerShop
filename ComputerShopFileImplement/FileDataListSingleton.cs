using ComputerShopContracts.Enums;
using ComputerShopFileImplement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace ComputerShopFileImplement
{
    public class FileDataListSingleton
    {
        private static FileDataListSingleton instance;

        private readonly string ComponentFileName = "Component.xml";
        private readonly string ComputerFileName = "Computer.xml";
        private readonly string OrderFileName = "Order.xml";

        public List<Component> Components { get; set; }

        public List<Computer> Computers { get; set; }

        public List<Order> Orders { get; set; }

        private FileDataListSingleton()
        {
            Components = LoadComponents();
            Computers = LoadComputers();
            Orders = LoadOrders();
        }

        public static FileDataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileDataListSingleton();
            }

            return instance;
        }

        public void SaveData()
        {
            instance.SaveComponents();
            instance.SaveOrders();
            instance.SaveComputers();
        }

        private List<Component> LoadComponents()
        {
            var list = new List<Component>();
            if (File.Exists(ComponentFileName))
            {
                var xDocument = XDocument.Load(ComponentFileName);
                var xElements = xDocument.Root.Elements("Component").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Component
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ComponentName = elem.Element("ComponentName").Value
                    });
                }
            }
            return list;
        }

        private List<Computer> LoadComputers()
        {
            var list = new List<Computer>();

            if (File.Exists(ComputerFileName))
            {
                var xDocument = XDocument.Load(ComputerFileName);

                var xElements = xDocument.Root.Elements("Computer").ToList();

                foreach (var elem in xElements)
                {
                    var computerComponents = new Dictionary<int, int>();

                    foreach (var component in elem.Element("ComputerComponents").Elements("ComputerComponent").ToList())
                    {
                        computerComponents.Add(Convert.ToInt32(component.Element("Key").Value), Convert.ToInt32(component.Element("Value").Value));
                    }

                    list.Add(new Computer
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ComputerName = elem.Element("ComputerName").Value,
                        Price = Convert.ToDecimal(elem.Element("Price").Value),
                        ComputerComponents = computerComponents
                    });
                }
            }
            return list;
        }

        private List<Order> LoadOrders()
        {
            var list = new List<Order>();

            if (File.Exists(OrderFileName))
            {
                XDocument xDocument = XDocument.Load(OrderFileName);

                var xElements = xDocument.Root.Elements("Order").ToList();

                foreach (var order in xElements)
                {
                    list.Add(new Order
                    {
                        Id = Convert.ToInt32(order.Attribute("Id").Value),
                        ComputerId = Convert.ToInt32(order.Element("ComputerId").Value),
                        Count = Convert.ToInt32(order.Element("Count").Value),
                        Sum = Convert.ToDecimal(order.Element("Sum").Value),
                        Status = (OrderStatus)Convert.ToInt32(order.Element("Status").Value),
                        DateCreate = Convert.ToDateTime(order.Element("DateCreate").Value),
                        DateImplement = !string.IsNullOrEmpty(order.Element("DateImplement").Value) ? Convert.ToDateTime(order.Element("DateImplement").Value) : (DateTime?)null
                    });
                }
            }
            return list;
        }

        private void SaveComponents()
        {
            if (Components != null)
            {
                var xElement = new XElement("Components");
                foreach (var component in Components)
                {
                    xElement.Add(new XElement("Component",
                    new XAttribute("Id", component.Id),
                    new XElement("ComponentName", component.ComponentName)));
                }
                var xDocument = new XDocument(xElement);

                xDocument.Save(ComponentFileName);
            }
        }

        private void SaveComputers()
        {
            if (Computers != null)
            {
                var xElement = new XElement("Computers");

                foreach (var computer in Computers)
                {
                    var componentsElement = new XElement("ComputerComponents");

                    foreach (var component in computer.ComputerComponents)
                    {
                        componentsElement.Add(new XElement("ComputerComponents",
                            new XElement("Key", component.Key),
                            new XElement("Value", component.Value)));
                    }

                    xElement.Add(new XElement("Computer",
                        new XAttribute("Id", computer.Id),
                        new XElement("ComputerName", computer.ComputerName),
                        new XElement("Price", computer.Price),
                        componentsElement));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ComputerFileName);
            }
        }

        private void SaveOrders()
        {
            if (Orders != null)
            {
                var xElement = new XElement("Orders");

                foreach (var order in Orders)
                {
                    xElement.Add(new XElement("Order",
                        new XAttribute("Id", order.Id),
                        new XElement("ComputerId", order.ComputerId),
                        new XElement("Count", order.Count),
                        new XElement("Sum", order.Sum),
                        new XElement("Status", (int)order.Status),
                        new XElement("DateCreate", order.DateCreate.ToString()),
                        new XElement("DateImplement", order.DateImplement.ToString())));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(OrderFileName);
            }
        }
    }
}
