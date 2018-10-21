using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace IPInfo
{
    public class IPResult : AbstractResult
    {
        internal IPResult(Dictionary<string, object> values) : base(values)
        {
            if (Values.ContainsKey("asn"))
                ASN = new ASNResult((Dictionary<string, object>)GetAndRemove("asn"));
            if (Values.ContainsKey("company"))
                Company = new COMPANYResult((Dictionary<string, object>)GetAndRemove("company"));
            if (Values.ContainsKey("carrier"))
                Carrier = new CARRIERResult((Dictionary<string, object>)GetAndRemove("carrier"));
        }

        /// <summary>
        /// IP Address
        /// </summary>
        public string IP => this["ip"];

        /// <summary>
        /// Hostname
        /// </summary>
        public string HostName => this["hostname"];

        /// <summary>
        /// City
        /// </summary>
        public string City => this["city"];

        /// <summary>
        /// Region
        /// </summary>
        public string Region => this["region"];

        /// <summary>
        /// Country
        /// </summary>
        public string Country => this["country"];

        /// <summary>
        /// Location
        /// </summary>
        public string Location => this["loc"];

        /// <summary>
        /// Postal
        /// </summary>
        public string Postal => this["postal"];

        /// <summary>
        /// Organisation
        /// </summary>
        public string Organisation => this["org"];

        /// <summary>
        /// ASN
        /// </summary>
        public ASNResult ASN { get; }

        /// <summary>
        /// Company
        /// </summary>
        public COMPANYResult Company { get; }

        /// <summary>
        /// Carrier
        /// </summary>
        public CARRIERResult Carrier { get; }
    }
}
