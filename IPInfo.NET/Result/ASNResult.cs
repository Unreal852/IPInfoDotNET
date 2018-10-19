using System.Collections.Generic;

namespace IPInfo
{
    public class ASNResult : AbstractResult
    {
        internal ASNResult(Dictionary<string, object> values) : base(values)
        {

        }

        /// <summary>
        /// ASN
        /// </summary>
        public string ASN => this["asn"];

        /// <summary>
        /// ASN Name
        /// </summary>
        public string Name => this["name"];

        /// <summary>
        /// ASN Domain
        public string Domain => this["domain"];

        /// <summary>
        /// ASN Route
        /// </summary>
        public string Route => this["route"];

        /// <summary>
        /// ASN Type
        /// </summary>
        public string Type => this["type"];
    }
}
