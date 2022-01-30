using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcfront.Models;
using Microsoft.EntityFrameworkCore;
using mvcfront.Data;
using mvcfront.Models.SchoolViewModels;
using System.Data.Common;
using Microsoft.Extensions.Logging;



namespace mvcfront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
/*
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        using (var client1 = new System.Net.Http.HttpClient())
            {
                // Call *mywebapi*, and display its response in the page
                var request = new System.Net.Http.HttpRequestMessage();
                // request.RequestUri = new Uri("http://kapi/WeatherForecast/saveme"); // ASP.NET 3 (VS 2019 only)
                string uriApi = "http://faApi/kubernetessystem/" + KubeType;
                request.RequestUri = new Uri(uriApi); // ASP.NET 3 (VS 2019 only)

                // request.RequestUri = new Uri("http://kapi/api/KubernetesSystem/GetSystemData"); // ASP.NET 3 (VS 2019 only)
                //request.RequestUri = new Uri("http://kapi/api/WeatherForecast/"); // ASP.NET 2.x
                var response = await client1.SendAsync(request);
                var resp = await response.Content.ReadAsStringAsync();
                return resp;
            }
*/
  
        private readonly SchoolContext _context;

        public HomeController(SchoolContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<ContentResult> CallApi()
        {

            using (var client1 = new System.Net.Http.HttpClient())
            {
                
                // Call *mywebapi*, and display its response in the page
                var request = new System.Net.Http.HttpRequestMessage();
                // requcd ..est.RequestUri = new Uri("http://kapi/WeatherForecast/saveme"); // ASP.NET 3 (VS 2019 only)
                //string uriApi = "http://localhost:5001/weatherforecast/";
                string uriApi = "http://apiback/weatherforecast/";
                request.RequestUri = new Uri(uriApi); // ASP.NET 3 (VS 2019 only)

                // request.RequestUri = new Uri("http://kapi/api/KubernetesSystem/GetSystemData"); // ASP.NET 3 (VS 2019 only)
                //request.RequestUri = new Uri("http://kapi/api/WeatherForecast/"); // ASP.NET 2.x
                var response = await client1.SendAsync(request);
                var resp = await response.Content.ReadAsStringAsync();
                return Content(resp); //View(resp);

            }
           // return View();
        }



        public IActionResult Index()
        {
            _logger.LogDebug("enter Index");
            return View();
        }

        public async Task<ActionResult> About()
        {
            List<EnrollmentDateGroup> groups = new List<EnrollmentDateGroup>();
            var conn = _context.Database.GetDbConnection();
            try
            {
                await conn.OpenAsync();
                using (var command = conn.CreateCommand())
                {
                    string query = "SELECT EnrollmentDate, COUNT(*) AS StudentCount "
                        + "FROM Student "
                       // + "WHERE Discriminator = 'Student' "
                        + "GROUP BY EnrollmentDate";
                    command.CommandText = query;
                    DbDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            var row = new EnrollmentDateGroup { EnrollmentDate = reader.GetDateTime(0), StudentCount = reader.GetInt32(1) };
                            groups.Add(row);
                        }
                    }
                    reader.Dispose();
                }
            }
            finally
            {
                conn.Close();
            }
            return View(groups);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       

    }
}



/*






















using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcfront.Models;

namespace mvcfront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
*/