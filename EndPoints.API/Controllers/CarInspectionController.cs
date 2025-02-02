using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using PersianDate;
using System.Globalization;
using System;
using PersianDate.Standard;


namespace EndPoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarInspectionController : ControllerBase
    {

        private readonly ICarInspectAppService _carInspectAppService;
        private readonly ICarModelAppService _carModelAppService;
        private readonly IRejectedLogsAppService _rejectedLogAppService;
        private readonly IOptions<SiteSetting> _siteSetting;

        public CarInspectionController(ICarInspectAppService carInspectAppService,
            ICarModelAppService carModelAppService,
            IRejectedLogsAppService rejectedLogAppService,
            IOptions<SiteSetting> siteSettings)
        {
            _carInspectAppService = carInspectAppService;
            _carModelAppService = carModelAppService;
            _rejectedLogAppService = rejectedLogAppService;
            _siteSetting = siteSettings;
        }


        [HttpGet("[action]")]
        //public Task Form()
        //{
        //    var carModels = _carModelAppService.GetCars().ToList();

        //    var carModelList = carModels.Select(cm => new SelectListItem
        //    {
        //        Value = cm.Id.ToString(),
        //        Text = $"{cm.Name} - {cm.Manufacturer}"
        //    }).ToList();

        //    ViewBag.CarModels = carModelList;
        //    return View("CarInspectForm");
        //}


        [HttpPost("[action]")]

        public string Form(CarInspection carInspect)
        {
            CarInspection newRequest = new CarInspection()
            {
                Id = carInspect.Id,
                CarModelId = carInspect.CarModelId,
                PlateNumber = carInspect.PlateNumber,
                OwnerAdress = carInspect.OwnerAdress,
                OwnerNationalId = carInspect.OwnerNationalId,
                OwnerPhoneNumber = carInspect.OwnerPhoneNumber,
                ProductionYear = carInspect.ProductionYear,
                RequestDate = carInspect.RequestDate,
                Status = InspectStatusEnum.Pending
            };

            //var saipaLimit = _siteSetting.Value.Limitation.Saipa;
            //var IranKhodroLimit = _siteSetting.Value.Limitation.IranKhodro;

            if (ModelState.IsValid)
            {
                //if (newRequest.CarModelId == 1)
                //{
                //    saipaLimit--;
                //}
                //else if (newRequest.CarModelId == 2)
                //{
                //    IranKhodroLimit--;
                //}


                if (newRequest.ProductionYear > 1398)
                {

                    _carInspectAppService.CreateCarInspection(newRequest);
                    return $"Successful,your request id is {newRequest.Id}";

                }
                else
                {
                    var rejectedLog = new RejectedLogs()
                    {
                        Id = carInspect.Id,
                        RequestDate = CarInspection.GetPersianDateAsDateTime(newRequest.RequestDate),
                        PlateNumber = newRequest.PlateNumber,
                        CarModelId = newRequest.CarModelId,
                        OwnerNationalId = newRequest.OwnerNationalId,
                        ProductionYear = newRequest.ProductionYear,
                        OwnerPhoneNumber = newRequest.OwnerPhoneNumber,
                        OwnerAdress = newRequest.OwnerAdress,
                        LogDate = DateTime.Now
                    };
                    _rejectedLogAppService.Add(rejectedLog);



                    return $"Your request is rejected, your request id is {rejectedLog.Id}";
                }
            }
            return "Invalid Request";

        }


        

    }
}

