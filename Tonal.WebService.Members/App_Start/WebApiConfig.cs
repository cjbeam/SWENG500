using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Tonal.WebService.Members {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Global Cors
            var corsAttr = new EnableCorsAttribute("http://psuwebmemberservice.azurewebsites.net","*","*");
            config.EnableCors(corsAttr);

            // Web API configuration and services
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
