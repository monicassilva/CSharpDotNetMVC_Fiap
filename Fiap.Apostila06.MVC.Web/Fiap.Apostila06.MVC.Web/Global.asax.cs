using Fiap.Apostila06.MVC.Web.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fiap.Apostila06.MVC.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Configurar a estratégia de criação das tabelas
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<PizzariaContext>());

        }
    }
}
