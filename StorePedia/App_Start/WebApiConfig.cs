using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace StorePedia
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            config.Routes.MapHttpRoute(
           name: "ControllerOnly",
           routeTemplate: "api/{controller}"
           );

            // Controller with ID
            config.Routes.MapHttpRoute(
            name: "ControllerAndId",
            routeTemplate: "api/{controller}/{id}",
            defaults: null,
            constraints: new { id = @"^\d+$" } // Only integers
            );

            // Controllers with Actions
            config.Routes.MapHttpRoute(
            name: "ControllerAndAction",
            routeTemplate: "api/{controller}/{action}"
            );


            //var json = config.Formatters.JsonFormatter;
            //json.SerializerSettings.PreserveReferencesHandling =
            //Newtonsoft.Json.PreserveReferencesHandling.None;

            //config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
