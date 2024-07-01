using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica08_JosueC_DanielT
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                literalSeleccion.Text = (String)Session["seleccion"];
                txtCosto.Text = (String)Session["costo"];
            }

        }
    }
}