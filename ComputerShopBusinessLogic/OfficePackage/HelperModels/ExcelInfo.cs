using ComputerShopContracts.ViewModels;
using System.Collections.Generic;

namespace ComputerShopBusinessLogic.OfficePackage.HelperModels
{
    public class ExcelInfo
    {
        public string FileName { get; set; }

        public string Title { get; set; }

        public List<ReportComputerComponentViewModel> ComputerComponents { get; set; }
    }
}
