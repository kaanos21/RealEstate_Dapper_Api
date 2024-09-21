using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ServicesRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;
        public ServiceRepository(Context context)
        {
            _context = context;
        }
        public void CreateServiceAsync(CreateServiceDto ServiceDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteServiceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select  * from Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdServiceDto> GetByIdServiceAsync(int id)
        {
            string query = "Select * from Service Where ServiceID=@CategoryID";
            var parametres = new DynamicParameters();
            parametres.Add("CategoryID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdServiceDto>(query, parametres);
                return values;
            }
        }

        public void UpdateServiceAsync(UpdateServiceDto ServiceDto)
        {
            throw new NotImplementedException();
        }
    }
}
