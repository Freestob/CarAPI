using MVC.CapstoneWeek8.Clients;
using MVC.CapstoneWeek8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVC.CapstoneWeek8.Controllers
{
    public class CarController : Controller
    {
        private readonly CarClient _carClient;
        public CarController()
        {
            _carClient = new CarClient();
        }
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }
        
        public async Task<ActionResult> GetCar(CarViewModel car)
        {
            var car1 = await _carClient.GetCar();
            return View(car1);
        }
    }
}