using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationClientMVC.Models;
namespace WebApplicationClientMVC.Controllers
{
    public class BalanceController : Controller
    {
        // GET: Balance
        //private Balance balance = new Balance();
      private static Balance balance = new Balance();
        public ActionResult Index()
        {
            
            return View(balance);
        }
        public static void SetBalance(Balance bal)
        {
            balance.load = bal.load;
            balance.listPlantPower = bal.listPlantPower;
            balance.Total = bal.Total;
            balance.Difference = bal.Difference;
            balance.BestPlantPower = bal.BestPlantPower;
            balance.Units = bal.Units;
            balance.BalanceResult = bal.BalanceResult;
        }
    }
}