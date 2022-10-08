using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operadores operadores = new Operadores();
        String oper;

        private void btmUm_Click(object sender, EventArgs e)
        {
            if (txtValores.Text == "0")
            {
                txtValores.Text = "1";
            }
            else
            {
                txtValores.Text = txtValores.Text + "1";
            }
        }
        private void btnDois_Click(object sender, EventArgs e)
        {
            if (txtValores.Text == "0")
            {
                txtValores.Text = "2";
            }
            else
            {
                txtValores.Text = txtValores.Text + "2";
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtValores.Text == "0")
            {
                txtValores.Text = "3";
            }
            else
            {
                txtValores.Text = txtValores.Text + "3";
            }
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (txtValores.Text == "0")
            {
                txtValores.Text = "4";
            }
            else
            {
                txtValores.Text = txtValores.Text + "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtValores.Text == "0")
            {
                txtValores.Text = "5";
            }
            else
            {
                txtValores.Text = txtValores.Text + "5";
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtValores.Text == "0")
            {
                txtValores.Text = "6";
            }
            else
            {
                txtValores.Text = txtValores.Text + "6";
            }
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (txtValores.Text == "0")
            {
                txtValores.Text = "7";
            }
            else
            {
                txtValores.Text = txtValores.Text + "7";
            }
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (txtValores.Text == "0")
            {
                txtValores.Text = "8";
            }
            else
            {
                txtValores.Text = txtValores.Text + "8";
            }
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (txtValores.Text == "0")
            {
                txtValores.Text = "9";
            }
            else
            {
                txtValores.Text = txtValores.Text + "9";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtValores.Text == "0")
            {
                txtValores.Text = "0";
            }
            else
            {
                txtValores.Text = txtValores.Text + "0";
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + ".";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            oper = "+";
            operadores.A = Convert.ToDouble(txtValores.Text);
            txtResultado.Text = txtValores.Text + "+";
            txtValores.Text = "0";
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            oper = "-";
            operadores.A = Convert.ToInt32(txtValores.Text);
            txtResultado.Text = txtValores.Text + "-";
            txtValores.Text = "0";
        }
        private void btnVezes_Click(object sender, EventArgs e)
        {
            oper = "×";
            operadores.A = Convert.ToInt32(txtValores.Text);
            txtResultado.Text = txtValores.Text + "×";
            txtValores.Text = "0";
        }
        private void btnBarra_Click(object sender, EventArgs e)
        {
            oper = "/";
            operadores.A = Convert.ToInt32(txtValores.Text);
            txtResultado.Text = txtValores.Text + "/";
            txtValores.Text = "0";
        }
        private void btnPorcento_Click(object sender, EventArgs e)
        {
            oper = "%";
            operadores.A = Convert.ToDouble(txtValores.Text);
            txtResultado.Text = txtValores.Text + "%";
            txtValores.Text = "0";
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtValores.Text = "0";
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            operadores.B = Convert.ToDouble(txtValores.Text);
            txtResultado.Text = txtResultado.Text + txtValores.Text;

            switch (oper)
            {
                case "+":
                    txtValores.Text = Convert.ToString(operadores.Adicao());
                    break;
                case "-":
                    txtValores.Text = Convert.ToString(operadores.Subtracao());
                    break;
                case "×":
                    txtValores.Text = Convert.ToString(operadores.Multiplicacao());
                    break;
                case "/":
                    txtValores.Text = Convert.ToString(operadores.Divisao());
                    break;
                case "%":
                    txtValores.Text = Convert.ToString(operadores.Porcento());
                    break;
            }
        }
        private void txtValores_TextChanged(object sender, EventArgs e)
        {

        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
