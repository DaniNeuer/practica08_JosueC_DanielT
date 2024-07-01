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
                costoTotal += float.Parse((String)Application[rbtDelgada.Text]);
            }
            else if (rbtPanPizza.Checked)
            {
                seleccion.Append(rbtPanPizza.Text + " ");
                costoTotal += float.Parse((String)Application[rbtPanPizza.Text]);
            }
            else if (rbtGruesa.Checked)
            {
                seleccion.Append(rbtGruesa.Text + " ");
                costoTotal += float.Parse((String)Application[rbtGruesa.Text]);
            }
            seleccion.Append("; Ingredientes: ");
            if (chkHongo.Checked)
            {
                seleccion.Append(chkHongo.Text + " ");
                costoTotal += float.Parse((String)Application[chkHongo.Text]);
            }
            if (chkPeperoni.Checked)
            {
                seleccion.Append(chkPeperoni.Text + " ");
                costoTotal += float.Parse((String)Application[chkPeperoni.Text]);
            }
            if (chkSalchicha.Checked)
            {
                seleccion.Append(chkSalchicha.Text + " ");
                costoTotal += float.Parse((String)Application[chkSalchicha.Text]);
            }
            literalSeleccionActual.Text = seleccion.ToString();
            txtTotal.Text = costoTotal.ToString();
        }

        protected void lnkCheckout_Click(object sender, EventArgs e)
        {

        }
    }
}