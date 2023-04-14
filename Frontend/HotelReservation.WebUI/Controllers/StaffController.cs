using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using HotelReservation.WebUI.Models.Staff;
using System.Threading.Tasks;
using System.Text;

namespace HotelReservation.WebUI.Controllers
{
    public class StaffController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5807/api/Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);
                return View(values);
            }

            return View();
           
        }
        [HttpGet]
        public IActionResult AddStaff()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff(AddStaffViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData= JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("http://localhost:5807/api/Staff", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> DeleteStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5807/api/Staff{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        //private   HttpClient CreateClient()
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage =  client.GetAsync("http://localhost:5807/api/Staff");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData =   responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}
    }

}
