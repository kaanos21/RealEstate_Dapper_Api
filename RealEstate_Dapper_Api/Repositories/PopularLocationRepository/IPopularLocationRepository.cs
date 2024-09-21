﻿using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepository
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        Task CreatePopularLocationAsync(CreatePopularLocationDto createPopularLocationDto);
        Task DeletePopularLocationAsync(int id);
        Task UpdatePopularLocationAsync(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIdPopularLocationDto> GetPopularLocationAsync(int id);
    }
}
