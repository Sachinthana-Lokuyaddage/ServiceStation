using Microsoft.AspNetCore.Mvc;
using ServiceStation.Web.Models;

namespace ServiceStation.Web.Controllers
{
    public class ServicesController : Controller
    {
        [ViewData]
        public string PageTitle { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            PageTitle = "Service Details";

            var service= new VehicleService
            {
                Id = 1,
                Title = "Oil Change",
                Description = "Change the engine oil and filter.",
                Cost = 29.99m,
                //isDeleted = false
            };

            // for viewData
            // ViewData["Service"] = service;


            //for viewbag
            //  ViewBag.Service = service;

            //for model
            //return View(service);


            return View(service);


        }
    }
}
