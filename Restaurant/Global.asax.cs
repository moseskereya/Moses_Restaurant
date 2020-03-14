using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Restaurant.Dal;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
namespace Restaurant
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var restaurantContext = new RestaurantContext();
            Database.SetInitializer(new RestaurantInitializer());
            restaurantContext.Database.Initialize(true);
        }
    }
}
