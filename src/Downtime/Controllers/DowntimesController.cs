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

            var draftMessage = @"**Maintenance Schedule Time: 12am-4am UTC**
**During this maintenance, Rave URLs will incur an approximate 20-minute outage as each server will need to be rebooted after the hotfix is installed.  **

**Details:** This is to notify you of the scheduled February 24th Rave URL downtime on the URL(s) listed above.

Medidata will be will be deploying an emergency hotfix to all Windows 2008 R2 servers in Houston Data Center (HDC).
During this maintenance, the affected URLs listed above in the HDC may be inaccessible and receive a maintenance page.  This maintenance is necessary due to a bug found in the Microsoft operating system. More details on the bug and hotfix can be found here: https://support.microsoft.com/en-us/help/2553549/all-the-tcp-ip-ports-that-are-in-a-time-wait-status-are-not-closed-aft

This is an automated email. Replies to this email are not monitored. If you need any technical assistance please contact the Medidata Helpdesk helpdesk@mdsol.com. For any other questions, please contact your Medidata Project Manager directly.

Thank you";

            var maintenance = new Maintenance
            {
                Start = DateTimeOffset.Now.AddDays(7).To8601(),
                End = DateTimeOffset.Now.AddDays(8).To8601(),
                ProductName = "Rave EDC",
                ProductUrls = productUrls,
                DraftMessage = draftMessage
            };

            return Ok(maintenance);
        }

        [HttpGet]
        [Route("/app_status")]
        public IActionResult AppStatus()
        {
            return Ok("OK");
        }
    }
}