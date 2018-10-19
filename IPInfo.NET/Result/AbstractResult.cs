using System.Collections.Generic;

namespace IPInfo
{
    public abstract class AbstractResult
    {
        public AbstractResult(Dictionary<string, object> values)
        {
            Values = values;
        }

        /// <summary>
        /// Key values
        /// </summary>
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

        /// <summary>
        /// Get and remove the specified value
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns><see cref="object"/> if the element exists, <see cref="null"/> otherwise</returns>
        protected object GetAndRemove(string key)
        {
            object obj = this[key];
            if (obj == null)
                return null;
            Values.Remove(key);
            return obj;
        }
    }
}
