using CrNET.Types.Default;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CrNET.Methods
{
    public class UrlBuilder
    {
        /// <summary>
        /// Create your query part of url.
        /// </summary>
        /// <param name="root">Parent directory</param>
        /// <param name="query">Collection with key/value queries.</param>
        /// <returns></returns>
        public static Uri BuildUri(string root, NameValueCollection query)
        {
            var collection = HttpUtility.ParseQueryString(string.Empty);
            foreach (var key in query.Cast<string>().Where(key => !string.IsNullOrEmpty(query[key])))
            {
                collection[key] = query[key];
            }
            var builder = new UriBuilder(root) { Query = collection.ToString() };
            return builder.Uri;
        }

        public static string GetCallBySearchFilter(SearchFilter filter, string baseUrl)
        {
            NameValueCollection myCollection = new NameValueCollection();
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            Type myType = filter.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(filter, null);
                var value = (propValue == null) || (propValue.Equals(0)) ? null : propValue.ToString();

                myCollection.Add(prop.Name.ToLower(), value);
            }
            var url = Request.GetCall(Request.Client.BaseUrl.AbsoluteUri, baseUrl);
            return UrlBuilder.BuildUri(url, myCollection).Query;
        }
    }
}
