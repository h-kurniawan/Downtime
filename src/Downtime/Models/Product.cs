using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Downtime.Models
{
    [DataContract]
    public class Product
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "product_urls")]
        public IEnumerable<ProductUrl> ProductUrls { get; set; }
    }
}
