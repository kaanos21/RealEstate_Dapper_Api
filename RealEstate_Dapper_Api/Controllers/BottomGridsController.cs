﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Repositories.BottomGridRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }
        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var vv= await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(vv);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
             _bottomGridRepository.CreateBottomGridAsync(createBottomGridDto);
            return Ok("Veri Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
             _bottomGridRepository.DeleteBottomGridAsync(id);
            return Ok("Veri Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
             _bottomGridRepository.UpdateBottomGridAsync(updateBottomGridDto);
            return Ok("Veri Başarıyla Güncellendi");
        }
        [HttpGet("GetByIdBottomGrid")]
        public async Task<IActionResult> GetBottomGrid(int id)
        {
            var value = await _bottomGridRepository.GetBottomGridAsync(id);
            return Ok(value);
        }
    }
}
