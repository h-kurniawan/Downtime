using Microsoft.AspNetCore.Mvc;
using Downtime.Data;
using System.Linq;

namespace Downtime.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DowntimesController : ControllerBase
    {
        private readonly IRequestRepository _requestRepository;

        public DowntimesController(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Index(int id)
        {
            var requests = _requestRepository.GetRequest(id);

            if (requests != null)
            {
                ReplaceDraftMessageStrings(requests);
                return Ok(requests);
            }
            else
                return NotFound();
        }

        [HttpGet]
        [Route("/app_status")]
        public IActionResult AppStatus()
        {
            return Ok("OK");
        }

        private void ReplaceDraftMessageStrings(NotificationRequest notification)
        {
            var newMessage = GetDraftMessageContent(notification);
            notification.DraftMessage = newMessage;
        }

        private static string GetDraftMessageContent(NotificationRequest notification)
        {
            return $@"## Overview:
This is to notify affected parties of changes to the Medidata FTP services   


## Maintenance Description:
The minimum encryption standards (TLS 1.2 or later, AES-128 or better and SHA-256 or better) defined by Information Security to secure communications with Medidata's FTP and EDI services will be changed and may require client action to accept the new standards. The update will incur no downtime to affect the change but if action is required by the end user, their client application will not allow data transfers until they have done so. 

The certificate used by the EDI services will change to one issued by Entrust.

A notification was distributed to all EDI clients several times since June 2018 and was posted to the client support site regarding this change and several others as well: https://support.mdsol.com/hc/en-us/articles/360000350567-TLS-1-2-Entrust-Certificate-FTP-Update-7-12-2018.

This change will only affect users of the AS2 and FTP protocols from clients located outside of the Houston Data Center. It will not affect connections from our hosted applications that use SMB rather than AS2 or FTP.


## Maintenance Date:
{notification.Start.ToString()} ({notification.Start.DayOfWeek})


## Maintenance Window:
{notification.Start.ToString()} to {notification.End.ToString()} 


## Action:
Notify Affected Clients of the change.

## Affected URLs:
`<urls will be filled in here>`

";
        }
    }
}