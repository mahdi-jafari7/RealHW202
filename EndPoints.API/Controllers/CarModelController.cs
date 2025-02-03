using Domain.AppService;
using Domain.Core._01_Entities;
using Domain.Core._02_Contracts.AppServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EndPoints.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarModelController : ControllerBase
    {
        private readonly ICarModelAppService _carmodelappservice;
        private readonly string _apiKey;

        public CarModelController(ICarModelAppService carmodelappservice, IOptions<ApiSettings> apiSettings)
        {
            _carmodelappservice = carmodelappservice;
            _apiKey = apiSettings.Value.ApiKey;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<CarModel>> GetCarModels(string apiKey)
        {
            if (apiKey == _apiKey)
            {

                return await _carmodelappservice.GetCars();

            }
            else
            {
                throw new Exception("api key is invalid!");
            }

        }



        [HttpPost("[action]")]
        public string RemoveCarModel(string apiKey, int id)
        {


            if (apiKey == _apiKey)
            {
                if (_carmodelappservice.GetCar(id) != null)
                {
                    _carmodelappservice.DeleteCar(id);
                    return $"Car Inspection with id {id} removed successfully";
                }
                return $"Car Inspection with id {id} not found";


            }
            else
            {
                throw new Exception("api key is invalid!");
            }

        }


        [HttpPost("[action]")]
        public string AddCarModel([FromHeader] string apiKey, [FromBody] CarModel carmodel)
        {


            if (apiKey == _apiKey)
            {

                _carmodelappservice.AddCar(carmodel);
                return $"Car Model added successfully";

            }
            else
            {
                throw new Exception("api key is invalid!");
            }

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> EditCarModel(string apiKey, int id, string name, string manufacturer)
        {
            if (apiKey != _apiKey)
            {
                return Unauthorized("API key is invalid!");
            }

            var carmodel = await _carmodelappservice.GetCar(id);

            if (carmodel == null)
            {
                return NotFound($"Car Model with ID {id} not found!");
            }

            carmodel.Name = name;  // توجه به بزرگ بودن N در Name
            carmodel.Manufacturer = manufacturer;

            await _carmodelappservice.EditCar(carmodel);

            return Ok($"Car Model with ID {carmodel.Id} edited successfully");
        }
    }
}

