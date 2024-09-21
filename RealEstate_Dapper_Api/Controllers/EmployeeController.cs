using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.EmployeeDto;
using RealEstate_Dapper_Api.Repositories.EmployeeRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _EmployeeRepository;
        public EmployeeController(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }
        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _EmployeeRepository.GetAllEmployeeAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            _EmployeeRepository.CreateEmployeeAsync(createEmployeeDto);
            return Ok("başarı ile eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            _EmployeeRepository.DeleteEmployeeAsync(id);
            return Ok("silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            _EmployeeRepository.UpdateEmployeeAsync(updateEmployeeDto);
            return Ok("Güncellendi");
        }
        [HttpGet("GetEmployeeById")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var value = await _EmployeeRepository.GetByIdEmployeeAsync(id);
            return Ok(value);
        }
    }
}
