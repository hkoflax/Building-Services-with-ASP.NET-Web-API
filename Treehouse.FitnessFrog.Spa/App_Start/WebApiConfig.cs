using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Treehouse.FitnessFrog.Spa
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var jsonSerialiserSettings = config.Formatters.JsonFormatter.SerializerSettings;
            jsonSerialiserSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            jsonSerialiserSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name:"DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id= RouteParameter.Optional});
        }
    }
}