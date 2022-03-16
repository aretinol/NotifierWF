using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NotifierWF
{
    public static class Extension
    {        
        public static Dictionary<string,string> ParseHeaders(string headers)
        {
            Dictionary<string, string> DictionaryHeaders = new Dictionary<string, string>();
            string[] KeysValues = headers.Split(new char[]{ '\r','\n'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in KeysValues)
            {
                string[] KeyValue = item.Split(new char[] { ':', ' '}, StringSplitOptions.RemoveEmptyEntries);
                string Key = KeyValue[0];
                string Value = KeyValue[1];
                DictionaryHeaders.Add(Key, Value);
            }
            return DictionaryHeaders;
        }
    }
}
