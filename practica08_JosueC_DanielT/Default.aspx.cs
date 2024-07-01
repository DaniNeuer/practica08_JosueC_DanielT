﻿using System;
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
            // Se agrega un nuevo cambio en el literal, que sera el tamaño
            seleccion.Append("; Tamaño: ");
            //verificamos que no sea null la seleccion del radio button
            if (rblTamano.SelectedItem != null)
            {
                //Agregamos a la seleccion que se agregara en el literal seguido con un espacio
                seleccion.Append(rblTamano.SelectedItem.Text + " ");
                //se agrega el costo final con el valor del value que se asigna al radiobutton que se seleccione
                costoTotal += float.Parse(rblTamano.SelectedItem.Value);
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
            // agregamos los extras a la seleccion
            seleccion.Append("; Extras: ");
            // recorregmos los items de la lista de check
            foreach (ListItem item in cblExtras.Items)
            {
                //verificamos si algun item ha sido chekeado
                if (item.Selected)
                {
                    // si el check es verdadero si agrega a la seleccion
                    seleccion.Append(item.Text + " ");
                    // se suma al costo final el valor de value del check
                    costoTotal += float.Parse(item.Value);
                }
            }
            // realizmoa la misma logica que en bibidas
            seleccion.Append("; Bebidas: ");
            foreach (ListItem item in cblBebidas.Items)
            {
                if (item.Selected)
                {
                    seleccion.Append(item.Text + " ");
                    costoTotal += float.Parse(item.Value);
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