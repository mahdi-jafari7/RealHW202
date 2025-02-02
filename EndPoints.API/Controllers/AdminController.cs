using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.AppServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EndPoints.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly string _apiKey;
        IAdminAppService _adminAppService;
        ICarInspectAppService _carInspectAppService;
        ICarModelAppService _carModelAppService;
        public ICarModelAppService CarModelAppService { get; }

        public AdminController(IAdminAppService adminAppService,
            ICarInspectAppService carInspectAppService,
            ICarModelAppService carModelAppService,
            IOptions<ApiSettings> apiSettings)
        {
            _adminAppService = adminAppService;
            _carInspectAppService = carInspectAppService;
            _carModelAppService = carModelAppService;
            _apiKey = apiSettings.Value.ApiKey;

        }


        [HttpGet("[action]")]
        public List<CarInspection> ListInspect(string apiKey)
        {


            if (apiKey == _apiKey)
            {
                var list = _carInspectAppService.GetAllCarInspections().ToList();
                return list;

            }
            else
            {
                throw new Exception("api key is invalid!");
            }

        }


    }
}
