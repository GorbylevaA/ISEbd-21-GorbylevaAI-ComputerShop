using ComputerShopContracts.BindingModels;
using ComputerShopContracts.BusinessLogicsContracts;
using ComputerShopContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ComputerShopRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientLogic _clientLogic;

        private readonly IMessageInfoLogic _mailLogic;

        public ClientController(IClientLogic clientLogic, IMessageInfoLogic mailLogic)
        {
            _clientLogic = clientLogic;
            _mailLogic = mailLogic;
        }

        [HttpGet]
        public ClientViewModel Login(string login, string password)
        {
            var list = _clientLogic.Read(new ClientBindingModel { Email = login, Password = password });
            return (list != null && list.Count > 0) ? list[0] : null;
        }

        [HttpPost]
        public void Register(ClientBindingModel model) => _clientLogic.CreateOrUpdate(model);

        [HttpPost]
        public void UpdateData(ClientBindingModel model) => _clientLogic.CreateOrUpdate(model);

        [HttpGet]
        public List<MessageInfoViewModel> GetMessages(int clientId) => _mailLogic.Read(new MessageInfoBindingModel { ClientId = clientId });
    }
}
