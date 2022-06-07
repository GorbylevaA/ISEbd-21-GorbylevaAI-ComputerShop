using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ComputerShopContracts.StoragesContracts
{
    public interface IBackUpInfo
    {
        Assembly GetAssembly();

        List<PropertyInfo> GetFullList();

        List<T> GetList<T>() where T : class, new();
    }
}
