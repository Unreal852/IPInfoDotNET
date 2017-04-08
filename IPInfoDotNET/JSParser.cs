using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace IPInfoDotNET
{
    internal class JSParser
    {
        private Dictionary<string, object> m_values;

        internal JSParser(string str)
        {
            Parse(str);
        }

        /// <summary>
        /// Try to parse the given string
        /// </summary>
        /// <param name="str">Serialized data</param>
        private void Parse(string str)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            try
            {
                m_values = js.Deserialize<Dictionary<string, object>>(str);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string this[string key]
        {
            get
            {
                if (m_values.ContainsKey(key))
                    return m_values[key] as string;
                return null;
            }
        }
    }
}
