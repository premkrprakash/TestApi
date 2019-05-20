using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Routing;

namespace WebAPITest.Routes
{
    public class AccountConatraint : IHttpRouteConstraint
    {
        public bool Match(HttpRequestMessage requestMessage,IHttpRoute route,string parameterValue,IDictionary<string,object> values,HttpRouteDirection direction)
        {
            object value;
            if (values.TryGetValue(parameterValue, out value) && value != null)
            {
                var stringVal = value as string;
                return (!String.IsNullOrEmpty(stringVal) &&
                    stringVal.StartsWith("1234") &&
                 stringVal.Length > 5);
            }
            else
                return false;
        }
    }
}