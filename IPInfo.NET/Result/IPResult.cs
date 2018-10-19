using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IPInfo
{
    public class IPResult : AbstractResult
    {
        internal IPResult(Dictionary<string, object> values) : base(values)
        {
            if(Values.ContainsKey("asn"))
            {
                ASN = new ASNResult((Dictionary<string, object>)Values["asn"]);
                Values.Remove("asn");
            }
            if (Values.ContainsKey("company"))
            {
                Company = new COMPANYResult((Dictionary<string, object>)Values["company"]);
                Values.Remove("company");
            }
            if (Values.ContainsKey("carrier"))
            {
                Carrier = new CARRIERResult((Dictionary<string, object>)Values["carrier"]);
                Values.Remove("carrier");
            }
        }

        [DataMember(Name = "ip")]
        public string IP => this["ip"];

        [DataMember(Name = "hostname")]
        public string HostName => this["hostname"];

        [DataMember(Name = "city")]
        public string City => this["city"];

        [DataMember(Name = "region")]
        public string Region => this["region"];

        [DataMember(Name = "country")]
        public string Country => this["country"];

        [DataMember(Name = "loc")]
        public string Location => this["loc"];

        [DataMember(Name = "postal")]
        public string Postal => this["postal"];

        [DataMember(Name = "org")]
        public string Organisation => this["org"];

        [DataMember(Name = "asn")]
        public ASNResult ASN { get; }

        [DataMember(Name = "company")]
        public COMPANYResult Company { get; }

        [DataMember(Name = "carrier")]
        public CARRIERResult Carrier { get; }
    }
}
