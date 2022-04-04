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
using Polly;
using System.Net.Http;
using System.Net;
using System.Text;

namespace mvcfront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
   
        private readonly SchoolContext _context;

        public HomeController(SchoolContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        //public async Task<ContentResult> CallApi()
        //public IActionResult CallApi()
        public async Task<IActionResult> CallApi()
        {
         
            using (var httpClient = new HttpClient())
            {
                var maxRetryAttempts = 3;
                var pauseBetweenFailures = TimeSpan.FromSeconds(2);

                var retryPolicy = Policy
                    .Handle<HttpRequestException>()
                    .WaitAndRetryAsync(maxRetryAttempts, i => pauseBetweenFailures);

                await retryPolicy.ExecuteAsync(async () =>
                {
                    var response = await httpClient
                    .GetAsync("http://localhost:5001/weatherforecast");
                    //response.EnsureSuccessStatusCode();
                    ViewData["json"] = response;
                });
                 
                 
            }
             

             return View();
 
        }



        public IActionResult Index()
        {
             /*
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName()); // `Dns.Resolve()` method is deprecated.

            int ct = ipHostInfo.AddressList.Count();
            StringBuilder sb = new StringBuilder();

            foreach(IPAddress ipx in ipHostInfo.AddressList)
            {
                sb.Append(ipx.ToString());
                sb.Append("  ");
            }
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            ViewData["ip"] = sb.ToString();
            */

            _logger.LogDebug("enter Index");
            return View();
        }

        public async Task<ActionResult> About()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName()); // `Dns.Resolve()` method is deprecated.

            int ct = ipHostInfo.AddressList.Count();
            StringBuilder sb = new StringBuilder();

            foreach (IPAddress ipx in ipHostInfo.AddressList)
            {
                sb.Append(ipx.ToString());
                sb.Append("  ");
            }
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            ViewData["ip"] = sb.ToString();


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


        [HttpGet]
        public ActionResult<IEnumerable<string>> Privacy()
       // public IActionResult Privacy()
        {
            if (new System.Random().NextDouble() > 0.5)
            {
                throw new System.Exception("test exception");
            }

            return new string[] { "value1", "value2" };
           // return View();
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