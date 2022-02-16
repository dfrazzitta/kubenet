using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Employee;


namespace apiback.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        IList <apiback.Employee> employees = new List <apiback.Employee> ()  
        {  
            new Employee()  
                {  
                    EmployeeId = 1, EmployeeName = "Mukesh Kumar", Address = "New Delhi", Department = "IT"  
                },  
                new Employee()  
                {  
                    EmployeeId = 2, EmployeeName = "Banky Chamber", Address = "London", Department = "HR"  
                },  
                new Employee()  
                {  
                    EmployeeId = 3, EmployeeName = "Rahul Rathor", Address = "Laxmi Nagar", Department = "IT"  
                },  
                new Employee()  
                {  
                    EmployeeId = 4, EmployeeName = "YaduVeer Singh", Address = "Goa", Department = "Sales"  
                },  
                new Employee()  
                {  
                    EmployeeId = 5, EmployeeName = "Manish Sharma", Address = "New Delhi", Department = "HR"  
                },  
        };  

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[GetList/{id?}]")]
        
        public IList <apiback.Employee> GetList( int y)
      //  public List<WeatherForecast> Get()
      // public HttpResponseMessage Get()
        {
            return apiback.employees; 
         // return Ok(gh);
        }



        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
      //  public List<WeatherForecast> Get()
      // public HttpResponseMessage Get()
        {
            var rng = new Random();
            return  Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToList();

           // return Ok(gh);
        }
    }
}
