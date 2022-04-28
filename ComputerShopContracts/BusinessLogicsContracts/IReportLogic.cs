using ComputerShopContracts.BindingModels;
using ComputerShopContracts.ViewModels;
using System.Collections.Generic;

namespace ComputerShopContracts.BusinessLogicsContracts
{
    public interface IReportLogic
    {
        List<ReportComputerComponentViewModel> GetComputerComponent();

        List<ReportOrdersViewModel> GetOrders(ReportBindingModel model);

        void SaveComputersToWordFile(ReportBindingModel model);

        void SaveComputerComponentToExcelFile(ReportBindingModel model);

        void SaveOrdersToPdfFile(ReportBindingModel model);
    }
}
