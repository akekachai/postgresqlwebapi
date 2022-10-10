using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostgresWebApi.Models;
using PostgresWebApi.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        private readonly ILinksrepositories<Links, string> _linksrepositories;

        public LinksController(ILinksrepositories<Links, string> linksrepositories)
        {
            _linksrepositories = linksrepositories;
        }

        [HttpPost]
        public async Task<IActionResult> insert(Links _links)
        {
            try
            {
                await _linksrepositories.Insert(_links);
                return Ok(new { success = true, message = "" });
            }
            catch(Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
          
        }

        //[HttpGet]
        //public  Task<IActionResult> getall()
        //{
        //    //try
        //    //{
        //    //    //var data = await _linksrepositories.GetAll();
        //    //    //return Ok(new { data = data ,success= true,message=""});
        //    //    return Ok(new {  success = true, message = "" });
        //    //}
        //    //catch(Exception ex)
        //    //{
        //    //    return BadRequest(new { success = false, message = ex.Message });
        //    //}

        //}
        private static readonly string[] Summaries = new[]
      {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
