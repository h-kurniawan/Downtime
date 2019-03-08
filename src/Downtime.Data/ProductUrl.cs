using System.Collections.Generic;

namespace Downtime.Data
{
    public class ProductUrl
    {
        public string Url { get; set; }

        public string Language { get; set; }

        public IEnumerable<string> ClientEmails { get; set; }

        public IEnumerable<string> ProjectManagerEmails { get; set; }
    }
}
