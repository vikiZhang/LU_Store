using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebForm_V1;
using Microsoft.Practices.Unity;
using WebForm_V1.Interface;
using WebForm_V1.Model;
using WebForm_V1.Controller;

namespace WebForm_V1
{
    
    public class Global : HttpApplication
    {
        public static IUnityContainer container;

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

            container = new UnityContainer();
            container.RegisterType<MainController>("main");
            container.RegisterType<IEmployee, Employee>();
           
           // Employee account = ApplicationConfiguration.GetStorageAccount("DataConnectionString");
            //container.RegisterInstance(account);

            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
    }
}
