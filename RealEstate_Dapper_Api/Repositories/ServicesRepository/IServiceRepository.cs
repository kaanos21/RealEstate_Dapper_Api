using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repositories.ServicesRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateServiceAsync(CreateServiceDto ServiceDto);
        void DeleteServiceAsync(int id);
        void UpdateServiceAsync(UpdateServiceDto ServiceDto);
        Task<GetByIdServiceDto> GetByIdServiceAsync(int id);
    }
}
