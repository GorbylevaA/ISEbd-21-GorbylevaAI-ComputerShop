using ComputerShopContracts.ViewModels;
using System.Collections.Generic;

namespace ComputerShopBusinessLogic.OfficePackage.HelperModels
{
    public class WordInfo
    {
        public string FileName { get; set; }

        public string Title { get; set; }

        public List<ComputerViewModel> Computers { get; set; }
    }
}
