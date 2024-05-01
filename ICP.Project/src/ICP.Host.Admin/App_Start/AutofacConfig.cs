﻿using Autofac;
using Autofac.Integration.Mvc;
using ICP.Infrastructure.Core.Frameworks;
using ICP.Infrastructure.Core.Web.Frameworks;
using ICP.Modules.Mvc.Authorization.App_Start;
using System.Reflection;
using System.Web.Mvc;

namespace ICP.Host.Admin.App_Start
{
    public static class AutofacConfig
    {
        /// <summary>
        /// 註冊DI注入物件資料
        /// </summary>
        public static void Register()
        {
            // 容器建立者
            ContainerBuilder builder = new ContainerBuilder();

            // 註冊 Controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // 攔截Attribute注入屬性
            builder.RegisterFilterProvider();

            // 載入模組
            builder.RegisterModule<DefaultHostModule>();
            builder.RegisterModule<AdminMvcModule>();

            // 建立容器
            IContainer container = builder.Build();

            // 解析容器內的型別
            AutofacDependencyResolver resolver = new AutofacDependencyResolver(container);

            // 建立相依解析器
            DependencyResolver.SetResolver(resolver);
        }
    }
}