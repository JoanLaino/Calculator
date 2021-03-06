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
        long resultado2 = 0;
        string signo;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtResultado.Enabled = false;
            if(!IsPostBack)
            {
                txtResultado.Text = "0";
                txtMiniatura.Text = "0";
            }           
        }

        protected void btnUno_Click(object sender, EventArgs e)
        {            
            if(txtResultado.Text == "0")
            {
                txtResultado.Text = "1";
                // txtMiniatura.Text = "1";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "1";
                // txtMiniatura.Text = number + "1";
            }
        }

        protected void btnDos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "2";
                // txtMiniatura.Text = "2";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "2";
                // txtMiniatura.Text = number + "2";
            }
            
        }

        protected void btnTres_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "3";
                // txtMiniatura.Text = "3";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "3";
                // txtMiniatura.Text = number + "3";
            }
        }

        protected void btnCuatro_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "4";
                // txtMiniatura.Text = "4";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "4";
                // txtMiniatura.Text = number + "4";
            }
        }

        protected void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "5";
                // txtMiniatura.Text = "5";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "5";
                // txtMiniatura.Text = number + "5";
            }
        }

        protected void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "6";
                // txtMiniatura.Text = "6";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "6";
                // txtMiniatura.Text = number + "6";
            }
        }

        protected void btnSiete_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "7";
                // txtMiniatura.Text = "7";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "7";
                // txtMiniatura.Text = number + "7";
            }
        }

        protected void btnOcho_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "8";
                // txtMiniatura.Text = "8";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "8";
                // txtMiniatura.Text = number + "8";
            }
        }

        protected void btnNueve_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "9";
                // txtMiniatura.Text = "9";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "9";
                // txtMiniatura.Text = number + "9";
            }
        }

        protected void btnCero_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "0";
                // txtMiniatura.Text = "0";
            }
            else
            {
                string number = txtResultado.Text;
                txtResultado.Text = number + "0";
                // txtMiniatura.Text = number + "0";
            }
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {           
            //Todavía hay que encontrar la manera de que la primera vez entre al if.
            if(Convert.ToString(Session["resultado2"]) == "0")
            { 
            resultado2 = Convert.ToInt64(txtResultado.Text);
            Session.Add("resultado2", resultado2);
            signo = "sumar";
            Session.Add("signo", signo);
            }
            else
            {
                long resultado3 = resultado2;
                resultado2 = resultado3 + Convert.ToInt64(txtResultado.Text);
                Session.Add("resultado2", resultado2);
                signo = "sumar";
                Session.Add("signo", signo);
            }

            if (txtMiniatura.Text == "0")
            {
                txtMiniatura.Text = " + " + txtResultado.Text;
            }
            else
            {
                txtMiniatura.Text = " + " + txtResultado.Text + txtMiniatura.Text;
            }   
            
            txtResultado.Text = "";            
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            signo = Convert.ToString(Session["signo"]);

            if (signo == "sumar")
            {
                txtMiniatura.Text = " + " + txtResultado.Text + txtMiniatura.Text;


                txtResultado.Text = Convert.ToString(((long)Session["resultado2"]) + Convert.ToInt64(txtResultado.Text));
            }
            else if (signo == "restar")
            {
                txtMiniatura.Text = " - " + txtResultado.Text + txtMiniatura.Text;


                txtResultado.Text = Convert.ToString(((long)Session["resultado2"]) - Convert.ToInt64(txtResultado.Text));
            }
            else if (signo == "multiplicar")
            {              
                txtMiniatura.Text = " * " + txtResultado.Text + txtMiniatura.Text;

                txtResultado.Text = Convert.ToString(((long)Session["resultado2"]) * Convert.ToInt64(txtResultado.Text));
            }
            else if (signo == "dividir")
            {
                txtMiniatura.Text = " / " + txtResultado.Text + txtMiniatura.Text;

                txtResultado.Text = Convert.ToString(((long)Session["resultado2"]) / Convert.ToInt64(txtResultado.Text));                
            }
            else
            {
                txtResultado.Text = "Syntax Error";
            }
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            resultado2 = Convert.ToInt64(txtResultado.Text);
            Session.Add("resultado2", resultado2);
            signo = "restar";
            Session.Add("signo", signo);

            if (txtMiniatura.Text == "0")
            {
                txtMiniatura.Text = " - " + txtResultado.Text;
            }
            else
            {
                txtMiniatura.Text = " - " + txtResultado.Text + txtMiniatura.Text;
            }

            txtResultado.Text = "";
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            resultado2 = Convert.ToInt64(txtResultado.Text);
            Session.Add("resultado2", resultado2);
            signo = "multiplicar";
            Session.Add("signo", signo);

            if (txtMiniatura.Text == "0")
            {
                txtMiniatura.Text = " * " + txtResultado.Text;
            }
            else
            {
                txtMiniatura.Text = " * " + txtResultado.Text + txtMiniatura.Text;
            }

            txtResultado.Text = "";
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            resultado2 = Convert.ToInt64(txtResultado.Text);
            Session.Add("resultado2", resultado2);
            signo = "dividir";
            Session.Add("signo", signo);

            if (txtMiniatura.Text == "0")
            {
                txtMiniatura.Text = " / " + txtResultado.Text;
            }
            else
            {
                txtMiniatura.Text = " / " + txtResultado.Text + txtMiniatura.Text;
            }

            txtResultado.Text = "";
        }

        protected void btnParentesisIzquierdo_Click(object sender, EventArgs e)
        {
            //if (txtResultado.Text == "0")
            //{
            //    txtResultado.Text = "(";
            //    // txtMiniatura.Text = "(";
            //}
            //else
            //{
            //    string number = txtResultado.Text;
            //    txtResultado.Text = number + " (";
            //    // txtMiniatura.Text = number + " (";
            //}            
        }

        protected void btnParentesisDerecho_Click(object sender, EventArgs e)
        {
            //if (txtResultado.Text == "0")
            //{
            //    txtResultado.Text = ")";
            //    // txtMiniatura.Text = ")";
            //}
            //else
            //{
            //    string number = txtResultado.Text;
            //    txtResultado.Text = number + " )";
            //    // txtMiniatura.Text = number + " )";
            //}
        }

        protected void btnCE_Click(object sender, EventArgs e)
        {
            resultado2 = 0;
            Session.Add("resultado2", resultado2);
            txtResultado.Text = "0";
            txtMiniatura.Text = "";
        }

        protected void btnX_Click(object sender, EventArgs e)
        {
            long cantidad = Convert.ToString(txtResultado).Length;

            for (int i = 0; i < cantidad; i++)
            {
                //Falta Codear
            }

        }
    }
}