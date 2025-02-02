using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.AppServices;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.MVC.Controllers
{
    public class CarModelController : Controller
    {
        private readonly ICarModelAppService _carmodelappservice;

        public CarModelController(ICarModelAppService carmodelappservice)
        {
            _carmodelappservice = carmodelappservice;
        }

        public IActionResult CarModelList()
        {
            var list = _carmodelappservice.GetCars();
            return View(list);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("CreateNewModel");
        }


        public IActionResult Add(CarModel newcarmodel)
        {
            _carmodelappservice.AddCar(newcarmodel);
            return RedirectToAction("CarModelList");
        }

        public IActionResult Remove(int id)
        {
            _carmodelappservice.DeleteCar(id);
            return RedirectToAction("CarModelList");
        }
    }
}
