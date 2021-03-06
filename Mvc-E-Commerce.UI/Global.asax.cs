﻿using Microsoft.AspNet.Identity;
using Mvc_E_Commerce.BLL.Controller;
using Mvc_E_Commerce.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Mvc_E_Commerce.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //var roller =new string[]{ "Admin", "User" };
            //var roleManager=MembershipTools.NewRoleManager();
            //foreach (var rol in roller)
            //{
            //    if (!roleManager.RoleExists(rol))
            //    {
            //        roleManager.Create(new Entity.IdentityModels.Role() {
            //            Name=rol
            //        });
            //    }
            //}
        }
    }
}
