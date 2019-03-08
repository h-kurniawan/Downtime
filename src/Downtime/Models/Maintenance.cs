using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Downtime.Models
{
    [DataContract]
    public class Maintenance
    {
        [DataMember(Name = "start")]
        public string Start { get; set; }

        [DataMember(Name = "end")]
        public string End { get; set; }

        [DataMember(Name = "product_name")]
        public string ProductName { get; set; }

        [DataMember(Name = "products")]
        public IEnumerable<ProductUrl> ProductUrls { get; set; }

        [DataMember(Name = "draft_message")]
        public string DraftMessage { get; set; }
    }
}
