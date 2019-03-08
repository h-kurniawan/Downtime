using System;
using System.Collections.Generic;

namespace Downtime.Models
{
    public class ProductUrl
    {
        public Uri Url { get; set; }

        public string IsoLanguage { get; set; }

        public IEnumerable<string> ProjectManagers { get; set; }

        public IEnumerable<string> EmailContacts { get; set; }
    }
}
