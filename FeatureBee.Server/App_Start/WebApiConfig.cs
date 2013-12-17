﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FeatureBee.Server
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/features/{id}",
                defaults: new { controller = "FeatureBeeApi", id = RouteParameter.Optional }
            );
        }
    }
}
