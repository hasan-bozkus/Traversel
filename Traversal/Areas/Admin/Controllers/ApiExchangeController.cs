using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Traversal.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System.Collections.Generic;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<BookingExchangeViewModel2> bookingExchangeViewModels = new List<BookingExchangeViewModel2>();
            string kur = "TRY";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency={kur}"),
                Headers =
    {
        { "x-rapidapi-key", "0d8cb4f5b0mshcf6e94f4f120a03p1e6e5bjsn85b6be86fe40" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
                return View(values.exchange_rates);
            }
            return View();
        }
    }
}
