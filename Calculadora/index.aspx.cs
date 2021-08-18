using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class index : System.Web.UI.Page
    {
        long resultado2;
        string signo;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtResultado.Enabled = false;
            if(!IsPostBack)
            {
                txtResultado.Text = "0";
            }           
        }

        protected void btnUno_Click(object sender, EventArgs e)
        {            
            if(txtResultado.Text == "0")
            {
                txtResultado.Text = "1";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "1";
            }
        }

        protected void btnDos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "2";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "2";
            }
            
        }

        protected void btnTres_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "3";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "3";
            }
        }

        protected void btnCuatro_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "4";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "4";
            }
        }

        protected void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "5";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "5";
            }
        }

        protected void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "6";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "6";
            }
        }

        protected void btnSiete_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "7";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "7";
            }
        }

        protected void btnOcho_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "8";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "8";
            }
        }

        protected void btnNueve_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "9";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "9";
            }
        }

        protected void btnCero_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "0";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "0";
            }
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            resultado2 = Convert.ToInt64(txtResultado.Text);
            signo = "sumar";
            txtResultado.Text = "0";
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            if (signo == "sumar")
            {
                txtResultado.Text = Convert.ToString(resultado2 + Convert.ToInt64(txtResultado.Text));
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "hola";
            }
        }
    }
}