using System.Collections.Generic;

namespace IPInfo
{
    public class CARRIERResult : AbstractResult
    {
        internal CARRIERResult(Dictionary<string, object> values) : base(values)
        {

        }

        /// <summary>
        /// Carrier Name
        /// </summary>
        public string Name => this["name"];

        /// <summary>
        /// MCC Uh what is this ?
        /// </summary>
        public string MCC => this["mcc"];

        /// <summary>
        /// MNC Uh what is this again ??
        public string MNC => this["mnc"];
    }
}
