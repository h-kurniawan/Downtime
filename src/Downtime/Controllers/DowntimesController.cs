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
        [Route("{id:int}")]
        public IActionResult Index(int id)
        {
            var productUrls = new ProductUrl[] {
                new ProductUrl
                {
                    Url = new Uri("https://amgen.mdsol.co.jp"),
                    IsoLanguage = "ja",
                    ProjectManagers = new[] { "John Doe" },
                    EmailContacts = new[] { "john.doe@amgen.co.jp" }
                },
                new ProductUrl
                {
                    Url = new Uri("https://amgen.mdsol.co.kr"),
                    IsoLanguage = "kr",
                    ProjectManagers = new[] { "John Wick" },
                    EmailContacts = new[] { "john.wick@amgen.co.kr" }
                },
                new ProductUrl
                {
                    Url = new Uri("https://amgen.mdsol.co.ch"),
                    IsoLanguage = "zh",
                    ProjectManagers = new[] { "Jack Reacher" },
                    EmailContacts = new[] { "jack.reacher@amgen.co.zh" }
                }
            };

            var maintenance = new Maintenance
            {
                Start = DateTimeOffset.Now.AddDays(7).To8601(),
                End = DateTimeOffset.Now.AddDays(8).To8601(),
                ProductName = "Rave EDC",
                ProductUrls = productUrls,
                DraftMessage = ""
            };

            return Ok(maintenance);
        }
    }
}
