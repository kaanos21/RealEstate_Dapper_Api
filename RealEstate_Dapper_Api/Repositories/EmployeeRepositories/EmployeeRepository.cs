using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.EmployeeDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;
        public EmployeeRepository(Context context)
        {
            _context = context;
        }
        public async void CreateEmployeeAsync(CreateEmployeeDto EmployeeDto)
        {
            string query = "insert into Employee (Name,Title,Mail,PhoneNumber,ImageUrl, Status) values (@name , @title,@mail,@phoneNumber,@imageUrl,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", EmployeeDto.Name);
            parameters.Add("@title", EmployeeDto.Title);
            parameters.Add("@mail", EmployeeDto.Mail);
            parameters.Add("@phoneNumber", EmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", EmployeeDto.ImageUrl);
            parameters.Add("@status", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployeeAsync(int id)
        {
            string query = "Delete from Employee where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "Select  * from Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdEmployeeDto> GetByIdEmployeeAsync(int id)
        {
            string query = "Select * from Employee Where EmployeeID=@employeeID";
            var parametres = new DynamicParameters();
            parametres.Add("employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdEmployeeDto>(query, parametres);
                return values;
            }
        }

        public async void UpdateEmployeeAsync(UpdateEmployeeDto EmployeeDto)
        {
            string query = "Update Employee Set Name=@name ,Title=@title, Mail=@mail ,ImageUrl=@imageUrl ,Status=@status where EmployeeID=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@name", EmployeeDto.Name);
            parameters.Add("@title", EmployeeDto.Title);
            parameters.Add("@mail", EmployeeDto.Mail);
            parameters.Add("@phoneNumber", EmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", EmployeeDto.ImageUrl);
            parameters.Add("@employeeId", EmployeeDto.EmployeeID);
            parameters.Add("@status", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
