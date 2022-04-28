using ComputerShopContracts.BindingModels;
using ComputerShopContracts.BusinessLogicsContracts;
using ComputerShopContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ComputerShopRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : Controller
    {
        private readonly IOrderLogic _order;

        private readonly IComputerLogic _computer;

        public MainController(IOrderLogic order, IComputerLogic computer)
        {
            _order = order;
            _computer = computer;
        }

        [HttpGet]
        public List<ComputerViewModel> GetComputerList() => _computer.Read(null)?.ToList();

        [HttpGet]
        public ComputerViewModel GetComputer(int computerId) => _computer.Read(new ComputerBindingModel { Id = computerId })?[0];

        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new OrderBindingModel { ClientId = clientId });

        [HttpPost]
        public void CreateOrder(CreateOrderBindingModel model) => _order.CreateOrder(model);
    }
}
