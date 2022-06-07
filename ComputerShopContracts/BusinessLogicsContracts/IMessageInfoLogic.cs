using ComputerShopContracts.BindingModels;
using ComputerShopContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerShopContracts.BusinessLogicsContracts
{
    public interface IMessageInfoLogic
    {
        List<MessageInfoViewModel> Read(MessageInfoBindingModel model);

        void CreateOrUpdate(MessageInfoBindingModel model);
    }
}
