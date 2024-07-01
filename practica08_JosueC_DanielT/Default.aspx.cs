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

            // Verificar y agregar el costo de la masa
            if (rbtDelgada.Checked)
            {
                seleccion.Append(rbtDelgada.Text + " ");
                string precioMasa = Application[rbtDelgada.Text] as string;
                if (!string.IsNullOrEmpty(precioMasa))
                {
                    costoTotal += float.Parse(precioMasa);
                }
            }
            else if (rbtPanPizza.Checked)
            {
                seleccion.Append(rbtPanPizza.Text + " ");
                string precioMasa = Application[rbtPanPizza.Text] as string;
                if (!string.IsNullOrEmpty(precioMasa))
                {
                    costoTotal += float.Parse(precioMasa);
                }
            }
            else if (rbtGruesa.Checked)
            {
                seleccion.Append(rbtGruesa.Text + " ");
                string precioMasa = Application[rbtGruesa.Text] as string;
                if (!string.IsNullOrEmpty(precioMasa))
                {
                    costoTotal += float.Parse(precioMasa);
                }
            }

            seleccion.Append("; Ingredientes: ");

            // Verificar y agregar el costo de los ingredientes
            if (chkHongo.Checked)
            {
                seleccion.Append(chkHongo.Text + " ");
                string precioIngrediente = Application[chkHongo.Text] as string;
                if (!string.IsNullOrEmpty(precioIngrediente))
                {
                    costoTotal += float.Parse(precioIngrediente);
                }
            }
            if (chkPeperoni.Checked)
            {
                seleccion.Append(chkPeperoni.Text + " ");
                string precioIngrediente = Application[chkPeperoni.Text] as string;
                if (!string.IsNullOrEmpty(precioIngrediente))
                {
                    costoTotal += float.Parse(precioIngrediente);
                }
            }
            if (chkSalchicha.Checked)
            {
                seleccion.Append(chkSalchicha.Text + " ");
                string precioIngrediente = Application[chkSalchicha.Text] as string;
                if (!string.IsNullOrEmpty(precioIngrediente))
                {
                    costoTotal += float.Parse(precioIngrediente);
                }
            }

            // Mostrar la selección y el costo total
            literalSeleccionActual.Text = seleccion.ToString();
            txtTotal.Text = costoTotal.ToString();
        }

        protected void lnkCheckout_Click(object sender, EventArgs e)
        {
            Session["seleccion"] = literalSeleccionActual.Text;
            Session["costo"] = txtTotal.Text;
            Response.Redirect("CheckOut.aspx");
        }
    }
}