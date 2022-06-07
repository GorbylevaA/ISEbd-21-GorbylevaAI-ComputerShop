using ComputerShopBusinessLogic.OfficePackage;
using ComputerShopBusinessLogic.OfficePackage.HelperModels;
using ComputerShopContracts.BindingModels;
using ComputerShopContracts.BusinessLogicsContracts;
using ComputerShopContracts.StoragesContracts;
using ComputerShopContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerShopBusinessLogic.BusinessLogics
{
    public class ReportLogic : IReportLogic
    {
        private readonly IComputerStorage _computerStorage;

        private readonly IOrderStorage _orderStorage;

        private readonly AbstractSaveToExcel _saveToExcel;

        private readonly AbstractSaveToWord _saveToWord;

        private readonly AbstractSaveToPdf _saveToPdf;

        public ReportLogic(IComputerStorage computerStorage, IOrderStorage orderStorage,
            AbstractSaveToExcel saveToExcel, AbstractSaveToWord saveToWord, AbstractSaveToPdf saveToPdf)
        {
            _computerStorage = computerStorage;
            _orderStorage = orderStorage;

            _saveToExcel = saveToExcel;
            _saveToWord = saveToWord;
            _saveToPdf = saveToPdf;
        }

        public List<ReportComputerComponentViewModel> GetComputerComponent()
        {
            var computers = _computerStorage.GetFullList();
            var list = new List<ReportComputerComponentViewModel>();
            foreach (var computer in computers)
            {
                var record = new ReportComputerComponentViewModel
                {
                    ComputerName = computer.ComputerName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in computer.ComputerComponents)
                {
                    record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
                    record.TotalCount += component.Value.Item2;
                }
                list.Add(record);
            }
            return list;
        }

        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return _orderStorage.GetFilteredList(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            })
            .Select(x => new ReportOrdersViewModel
            {
                DateCreate = x.DateCreate,
                ComputerName = x.ComputerName,
                Count = x.Count,
                Sum = x.Sum,
                Status = x.Status
            })
           .ToList();
        }

        public void SaveComputersToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список компьютеров",
                Computers = _computerStorage.GetFullList()
            });
        }

        public void SaveComputerComponentToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReport(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список компьютеров",
                ComputerComponents = GetComputerComponent()
            });
        }

        public void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            _saveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Orders = GetOrders(model)
            });
        }
    }
}
