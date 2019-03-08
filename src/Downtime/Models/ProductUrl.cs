using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Downtime.Models
{
    [DataContract]
    public class ProductUrl
    {
        [DataMember(Name = "url")]
        public Uri Url { get; set; }

        [DataMember(Name = "iso_language")]
        public string IsoLanguage { get; set; }

        [DataMember(Name = "project_managers")]
        public IEnumerable<string> ProjectManagers { get; set; }

        [DataMember(Name = "email_contacts")]
        public IEnumerable<string> EmailContacts { get; set; }
    }
}
