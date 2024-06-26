﻿using Dapper;
using RealEstate_Dapper_.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly Context _context;

        public StatisticsRepository(Context context)
        {
            _context = context;
        }

        public int ActiveCategoryCount()
        {
            string query = "Select Count(*)From Category where CategoryStatus=1";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int?>(query);
                return values ?? 0;
            }
        }

        public int ActiveEmployeeCount()
        {
            string query = "Select Count(*)From Employee  where Status=1";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int?>(query);
                return values ?? 0;
            }
        }

        public int ApartmentCount()
        {
            string query = "Select Count(*) From Product where Title like '%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int?>(query);
                return values ?? 0;
            }
        }

        public decimal AverageProductPriceBySale()
        {
            string query = "Select Avg(Price) From Product where Type='Satılık'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal?>(query);
                return values ?? 0;
            }
        }

        public decimal AverageProductPriceByRent()
        {
            string query = "Select Avg(Price) From Product where Type= 'Kiralık'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal?>(query);
                return values ?? 0;
            }
        }

        public int AverageRoomCount()
        {
            string query = "Select AVG(RoomCount) From ProductDetails";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int?>(query);
                return values??0;
            }
        }

        public int CategoryCount()
        {
            string query = "Select Count(*) From Category";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int?>(query);
                return values ?? 0;
            }
        }

        public string CategoryNameByMaxProductCount()
        {
            string query = "Select top(1) CategoryName, Count(*) From Product inner join Category on Product.ProductCategory=Category.CategoryId Group By CategoryName order by Count(*) Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string?>(query);
                return values??"";
            }
        }

        public string CityNameByMaxProductCount()
        {
            string query = "Select top(1) City, Count(*) as 'ilan_Sayisi' From Product  Group By City order by ilan_Sayisi Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string?>(query);
                return values??"";
            }
        }

        public int DifferentCityCount()
        {
            string query = "Select Count(Distinct(City)) from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int?>(query);
                return values ?? 0;
            }
        }

        public string EmployeeNameByMaxProductCount()
        {
            string query = "Select top(1) Employee.Name, Count(*) as 'product_count' From Product inner join Employee on Product.EmployeeId=Employee.EmployeeId Group By Employee.Name order by product_count Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string?>(query);
                return values??"";
            }
        }

        public decimal LastProductPrice()
        {
            string query = "Select top(1) Price from Product Order By ProductId Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal?>(query);
                return values ?? 0;
            }
        }

        public string NewestBuildingYear()
        {
            string query = "Select top(1) ProductDetails.BuildYear from Product inner join ProductDetails on Product.ProductId=ProductDetails.ProductId Order By ProductDetails.BuildYear Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string?>(query);
                return values ?? "";
            }
        }
        
        public string OldestBuildingYear()
        {
            string query = "Select top(1) ProductDetails.BuildYear from Product inner join ProductDetails on Product.ProductId=ProductDetails.ProductId Order By ProductDetails.BuildYear Asc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string?>(query);
                return values??"";
            }
        }

        public int PassiveCategoryCount()
        {
            string query = "Select Count(*)From Category where CategoryStatus=0";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int?>(query);
                return values ?? 0;
            }
        }

        public int ProductCount()
        {
            string query = "Select Count(*) From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int?>(query);
                return values ?? 0;
            }
        }
    }
}
