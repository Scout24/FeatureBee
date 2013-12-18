﻿using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using FeatureBee.Configuration;

namespace FeatureBee
{
    public class HttpHandler: IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            switch (context.Request.Path.ToLowerInvariant())
            {
                case "/featurebee.axd/features":
                    context.Response.Write(GetFeaturesAsJson());
                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = (int)HttpStatusCode.OK;
                    break;
                default:
                    context.Response.StatusCode = (int)HttpStatusCode.NotImplemented;
                    break;
            }
        }

        private static string GetFeaturesAsJson()
        {
            var serializer = new JavaScriptSerializer();
            var features = FeatureBeeBuilder.Context.FeatureRepository.GetFeatures();
            return serializer.Serialize(features);
        }

        public bool IsReusable { get { return true; }}
    }
}