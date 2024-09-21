using RealEstate_Dapper_Api.Dtos.BottomGridDtos;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGridAsync(CreateBottomGridDto BottomGridDto);
        void DeleteBottomGridAsync(int id);
        void UpdateBottomGridAsync(UpdateBottomGridDto BottomGridDto);
        Task<GetBottomGridDto> GetBottomGridAsync(int id);
    }
}
