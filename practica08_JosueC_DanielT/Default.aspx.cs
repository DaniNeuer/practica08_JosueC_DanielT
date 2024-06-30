using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica08_JosueC_DanielT
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["seleccion"] = "";
                Session["costo"] = "0";
            }
        }
        protected void Opciones_CheckedChanged(object sender, EventArgs e)
        {
            StringBuilder seleccion = new StringBuilder("Tipo de masa: ");
            float costoTotal = 0;
            if (rbtDelgada.Checked)
            {
                seleccion.Append(rbtDelgada.Text + " ");
                costoTotal += 5;
            }
            else if (rbtPanPizza.Checked)
            {
                seleccion.Append(rbtPanPizza.Text + " ");
                costoTotal += 8;
            }
            else if (rbtGruesa.Checked)
            {
                seleccion.Append(rbtGruesa.Text + " ");
                costoTotal += 10;
            }
            seleccion.Append("; Ingredientes: ");
            if (chkHongo.Checked)
            {
                seleccion.Append(chkHongo.Text + " ");
                costoTotal += 8;
            }
            if (chkPeperoni.Checked)
            {
                seleccion.Append(chkPeperoni.Text + " ");
                costoTotal += 10;
            }
            if (chkSalchicha.Checked)
            {
                seleccion.Append(chkSalchicha.Text + " ");
                costoTotal += 12;
            }
            literalSeleccionActual.Text = seleccion.ToString();
            txtTotal.Text = costoTotal.ToString();
        }
    }
}