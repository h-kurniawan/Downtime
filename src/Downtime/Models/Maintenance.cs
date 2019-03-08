using System.Collections.Generic;

namespace Downtime.Models
{
    public class Maintenance
    {
        public string Start { get; set; }

        public string End { get; set; }

        public string ProductName { get; set; }

        public IEnumerable<ProductUrl> ProductUrls { get; set; }

        public string DraftMessage { get; set; }
    }
}
