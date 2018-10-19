using System.Collections.Generic;

namespace IPInfo
{
    public class COMPANYResult : AbstractResult
    {
        internal COMPANYResult(Dictionary<string, object> values) : base(values)
        {

        }

        /// <summary>
        /// Company Name
        /// </summary>
        public string Name => this["name"];

        /// <summary>
        /// Company Domain
        public string Domain => this["domain"];

        /// <summary>
        /// Company Type
        /// </summary>
        public string Type => this["type"];
    }
}
