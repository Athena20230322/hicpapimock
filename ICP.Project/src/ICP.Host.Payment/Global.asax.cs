﻿using ICP.Host.Payment.App_Start;
using ICP.Infrastructure.Core.Frameworks;
using ICP.Infrastructure.Core.Web.Extensions;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ICP.Host.Payment
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // 自定義模組
            AutofacConfig.Register();
            LoggerConfig.Register();
            AutoMapperConfig.Register();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // 讓每一個請求都有自己獨立的編號
            HttpContext.Current.GenerateRequestId();
        }

        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            // 讀取識別cookie
            ICP.Modules.Mvc.Authorization.Services.IdentifyService.LoadCookie(Context, Request);
        }
    }
}