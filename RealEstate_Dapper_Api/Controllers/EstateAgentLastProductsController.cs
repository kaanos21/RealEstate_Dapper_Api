﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.LastProductRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductsController : ControllerBase
    {
        private readonly ILast5ProductRepository _lastProductRepository;

        public EstateAgentLastProductsController(ILast5ProductRepository lastProductRepository)
        {
            _lastProductRepository = lastProductRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetLast5ProductAsync(int id)
        {
            return Ok(await _lastProductRepository.GetLast5ProductAsync(id));
        }
    }
}
