using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Repositories.ServicesRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : Controller
    {

        private readonly IServiceRepository _ServiceRepository;
        public ServicesController(IServiceRepository ServiceRepository)
        {
            _ServiceRepository = ServiceRepository;
        }
        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _ServiceRepository.GetAllServiceAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            _ServiceRepository.CreateServiceAsync(createServiceDto);
            return Ok("başarı ile eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            _ServiceRepository.DeleteServiceAsync(id);
            return Ok("silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            _ServiceRepository.UpdateServiceAsync(updateServiceDto);
            return Ok("Güncellendi");
        }
        [HttpGet("GetServiceById")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await _ServiceRepository.GetByIdServiceAsync(id);
            return Ok(value);
        }
    }
}
