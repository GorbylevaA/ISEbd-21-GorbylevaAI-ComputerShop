﻿namespace ComputerShopContracts.BusinessLogicsContracts
{
    public interface IWorkProcess
    {
        void DoWork(IImplementerLogic implementerLogic, IOrderLogic orderLogic);
    }
}
