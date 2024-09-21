using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.StatisticsRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public StatisticController(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }
        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            var x=_statisticsRepository.ActiveCategoryCount();
            return Ok(x);
        } 
        [HttpGet("ActiveEmployeeCount")]
        public IActionResult ActiveEmployeeCount()
        {
            var x=_statisticsRepository.ActiveEmployeeCount();
            return Ok(x);
        }
        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            var x=_statisticsRepository.ApartmentCount();
            return Ok(x);
        }
        [HttpGet("AverageProductPriceByRent")]
        public IActionResult AverageProductPriceByRent()
        {
            var x=_statisticsRepository.AverageProductPriceByRent();
            return Ok(x);
        }
        [HttpGet("AverageProductPriceBySale")]
        public IActionResult AverageProductPriceBySale()
        {
            var x=_statisticsRepository.AverageProductPriceBySale();
            return Ok(x);
        }
        [HttpGet("AvgRoomCount")]
        public IActionResult AvgRoomCount()
        {
            var x=_statisticsRepository.AvgRoomCount();
            return Ok(x);
        }
        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            var x=_statisticsRepository.CategoryCount();
            return Ok(x);
        }
        [HttpGet("CategoryNameByMaxProductCount")]
        public IActionResult CategoryNameByMaxProductCount()
        {
            var x=_statisticsRepository.CategoryNameByMaxProductCount();
            return Ok(x);
        }
        [HttpGet("CityNameByMaxProductCount")]
        public IActionResult CityNameByMaxProductCount()
        {
            var x=_statisticsRepository.CityNameByMaxProductCount();
            return Ok(x);
        }
        [HttpGet("DifferentCityCount")]
        public IActionResult DifferentCityCount()
        {
            var x=_statisticsRepository.DifferentCityCount();
            return Ok(x);
        }
        [HttpGet("EmployeeNameByMaxProductCount")]
        public IActionResult EmployeeNameByMaxProductCount()
        {
            var x=_statisticsRepository.EmployeeNameByMaxProductCount();
            return Ok(x);
        }
        [HttpGet("LastProductPrice")]
        public IActionResult LastProductPrice()
        {
            var x=_statisticsRepository.LastProductPrice();
            return Ok(x);
        }
        [HttpGet("NewestBuildingYear")]
        public IActionResult NewestBuildingYear()
        {
            var x=_statisticsRepository.NewestBuildingYear();
            return Ok(x);
        }
        [HttpGet("OldestBuildingYear")]
        public IActionResult OldestBuildingYear()
        {
            var x=_statisticsRepository.OldestBuildingYear();
            return Ok(x);
        }
        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            var x=_statisticsRepository.PassiveCategoryCount();
            return Ok(x);
        }
        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            var x=_statisticsRepository.ProductCount();
            return Ok(x);
        }
    }
}
