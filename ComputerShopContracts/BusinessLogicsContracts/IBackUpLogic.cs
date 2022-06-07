using ComputerShopContracts.BindingModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerShopContracts.BusinessLogicsContracts
{
    public interface IBackUpLogic
    {
        void CreateBackUp(BackUpSaveBinidngModel model);
    }
}
