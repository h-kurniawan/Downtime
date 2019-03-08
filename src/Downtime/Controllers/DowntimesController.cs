using System;
using Downtime.Models;
using Microsoft.AspNetCore.Mvc;
using Downtime.Extensions;

namespace Downtime.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DowntimesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var productUrls = new ProductUrl[] {
                new ProductUrl
                {
                    Url = new Uri("https://amgen.mdsol.co.jp"),
                    IsoLanguage = "ja",
                },
                new ProductUrl
                {
                    Url = new Uri("https://amgen.mdsol.co.kr"),
                    IsoLanguage = "kr",
                },
                new ProductUrl
                {
                    Url = new Uri("https://amgen.mdsol.co.ch"),
                    IsoLanguage = "zh",
                }
            };

            var products = new Product
            {
                Name = "Rave EDC",
                ProductUrls = productUrls
            };

            var maintenance = new Maintenance
            {
                Start = DateTimeOffset.Now.AddDays(7).To8601(),
                End = DateTimeOffset.Now.AddDays(8).To8601(),
                Products = new[] { products },
                DraftMessage = ""
            };

            return Ok(maintenance);
        }
    }
}
