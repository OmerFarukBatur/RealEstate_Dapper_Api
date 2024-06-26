﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region ActiveCategoryCount
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.ActiveCategoryCount = jsonData;
            #endregion

            #region ActiveEmployeeCount
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44368/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.ActiveEmployeeCount = jsonData2;
            #endregion

            #region ApartmentCount
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44368/api/Statistics/ActiveCategoryCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.ApartmentCount = jsonData3;
            #endregion

            #region AverageProductPriceBySale
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44368/api/Statistics/ActiveCategoryCount");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceBySale = jsonData4;
            #endregion

            #region AverageProductPriceByRent
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:44368/api/Statistics/AverageProductPriceByRent");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceByRent = jsonData5;
            #endregion

            #region AverageRoomCount
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:44368/api/Statistics/AverageRoomCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.AverageRoomCount = jsonData6;
            #endregion

            #region CategoryCount
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:44368/api/Statistics/CategoryCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.CategoryCount = jsonData7;
            #endregion

            #region CategoryNameByMaxProductCount
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:44368/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.CategoryNameByMaxProductCount = jsonData8;
            #endregion

            #region CityNameByMaxProductCount
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:44368/api/Statistics/CityNameByMaxProductCount");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.CityNameByMaxProductCount = jsonData9;
            #endregion

            #region DifferentCityCount
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:44368/api/Statistics/DifferentCityCount");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.DifferentCityCount = jsonData10;
            #endregion

            #region EmployeeNameByMaxProductCount
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client.GetAsync("https://localhost:44368/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.EmployeeNameByMaxProductCount = jsonData11;
            #endregion

            #region LastProductPrice
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:44368/api/Statistics/LastProductPrice");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.LastProductPrice = jsonData12;
            #endregion

            #region NewestBuildingYear
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client13.GetAsync("https://localhost:44368/api/Statistics/NewestBuildingYear");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.NewestBuildingYear = jsonData13;
            #endregion

            #region OldestBuildingYear
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("https://localhost:44368/api/Statistics/OldestBuildingYear");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.OldestBuildingYear = jsonData14;
            #endregion

            #region PassiveCategoryCount
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("https://localhost:44368/api/Statistics/PassiveCategoryCount");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.PassiveCategoryCount = jsonData15;
            #endregion

            #region ProductCount
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client16.GetAsync("https://localhost:44368/api/Statistics/ProductCount");
            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData16;
            #endregion
                        
            return View();
        }
    }
}
