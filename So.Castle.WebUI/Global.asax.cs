using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using So.Castle.Core;
using So.Castle.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace So.Castle.WebUI
{
    public class Global : System.Web.HttpApplication
    {
        #region Fields

        private Container container;

        #endregion

        protected void Application_Start()
        {
            IConfigurationSource source = System.Configuration.ConfigurationManager.GetSection("activerecord") as IConfigurationSource;
            ActiveRecordStarter.Initialize(typeof(Users).Assembly, source);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            container = Container.Instance;
        }

        protected void Application_End(object sender, EventArgs e)
        {
            container.Dispose();
        }
    }
}