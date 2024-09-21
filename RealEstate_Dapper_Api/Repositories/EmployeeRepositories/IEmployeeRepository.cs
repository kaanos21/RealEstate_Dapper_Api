using RealEstate_Dapper_Api.Dtos.EmployeeDto;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        void CreateEmployeeAsync(CreateEmployeeDto EmployeeDto);
        void DeleteEmployeeAsync(int id);
        void UpdateEmployeeAsync(UpdateEmployeeDto EmployeeDto);
        Task<GetByIdEmployeeDto> GetByIdEmployeeAsync(int id);
    }
}
