namespace RealEstate_Dapper_Api.Repositories.StatisticsRepositories
{
    public interface IStatisticsRepository
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int ProductCount();
        int ApartmentCount();
        string EmployeeNameByMaxProductCount();
        string CategoryNameByMaxProductCount();
        int AverageProductPriceByRent();
        int AverageProductPriceBySale();
        string CityNameByMaxProductCount();
        int DifferentCityCount();
        int LastProductPrice();
        int NewestBuildingYear();
        int OldestBuildingYear();
        int AvgRoomCount();
        int ActiveEmployeeCount();

    }
}
