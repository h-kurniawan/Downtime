using System;
using System.Collections;
using System.Collections.Generic;

namespace Downtime.Data
{
    public class NotificationRequest
    {
        public int Id { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string DraftMessage { get; set; }

        public string ProductName { get; set; }

        public IEnumerable<ProductUrl> ProductUrls { get; set; }
    }
}
