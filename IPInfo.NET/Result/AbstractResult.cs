using System.Collections.Generic;

namespace IPInfo
{
    public abstract class AbstractResult
    {
        public AbstractResult(Dictionary<string, object> values)
        {
            Values = values;
        }

        protected Dictionary<string, object> Values { get; set; }

        protected string this[string key]
        {
            get
            {
                if (Values.ContainsKey(key))
                    return Values[key].ToString();
                return null;
            }
        }
    }
}
