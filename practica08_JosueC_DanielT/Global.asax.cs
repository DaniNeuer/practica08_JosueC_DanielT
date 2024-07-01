using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace practica08_JosueC_DanielT
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Delgada"] = "5";
            Application["Panpizza"] = "8";
            Application["Gruesa"] = "10";
            Application["Champiñones"] = "8";
            Application["Peperoni"] = "10";
            Application["Salchicha"] = "12";
        }
    }
}