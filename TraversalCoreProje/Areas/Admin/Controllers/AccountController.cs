using BussinessLayer.Abstract.AbstractUow;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountViewModel viewModel)
        {
            var valueSender=_accountService.TGetbyId(viewModel.SenderId); 
            var valuesReceiver=_accountService.TGetbyId(viewModel.ReciverId); 
            
            valueSender.Balance -=viewModel.Amount; 
             valuesReceiver.Balance +=viewModel.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valueSender, 
                valuesReceiver
            };
            _accountService.TMultiUpdate(modifiedAccounts);
            return View();
        }
    }
}
