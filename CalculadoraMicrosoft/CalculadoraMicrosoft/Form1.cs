using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CalculadoraMicrosoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool detectaopreacion = true;
        string operacion;
        double result;
        double numero1;
        double numero2;
        bool punto = true;
        string borrado, point;
        double Signos;



        // botones numéricos
        private void cero_Click(object sender, EventArgs e) {
            if (detectaopreacion) {
                txtpantalla.Text = "";
                txtpantalla.Text = "0";
                detectaopreacion = false;

            } else {
                txtpantalla.Text = txtpantalla.Text + "0";
            }
        }
        private void uno_Click(object sender, EventArgs e) {
            if (detectaopreacion) {
                txtpantalla.Text = "";
                txtpantalla.Text = "1";
                detectaopreacion = false;

            } else {
                txtpantalla.Text = txtpantalla.Text + "1";
            }
        }

        private void dos_Click(object sender, EventArgs e) {
            if (detectaopreacion) {
                txtpantalla.Text = "";
                txtpantalla.Text = "2";
                detectaopreacion = false;

            }
            else {
                txtpantalla.Text = txtpantalla.Text + "2";
            }
        }

        private void tres_Click(object sender, EventArgs e) {
            if (detectaopreacion) {
                txtpantalla.Text = "";
                txtpantalla.Text = "3";
                detectaopreacion = false;

            } else {
                txtpantalla.Text = txtpantalla.Text + "3";
            }
        }

        private void cuatro_Click(object sender, EventArgs e) {
            if (detectaopreacion) {
                txtpantalla.Text = "";
                txtpantalla.Text = "4";
                detectaopreacion = false;

            } else {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
        }

        private void cinco_Click(object sender, EventArgs e) {
            if (detectaopreacion) {
                txtpantalla.Text = "";
                txtpantalla.Text = "5";
                detectaopreacion = false;

            } else {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
        }

        private void seis_Click(object sender, EventArgs e) {
            if (detectaopreacion) {
                txtpantalla.Text = "";
                txtpantalla.Text = "6";
                detectaopreacion = false;

            } else {
                txtpantalla.Text = txtpantalla.Text + "6";
            }
        }

        private void siete_Click(object sender, EventArgs e) {
            if (detectaopreacion) {
                txtpantalla.Text = "";
                txtpantalla.Text = "7";
                detectaopreacion = false;

            } else {
                txtpantalla.Text = txtpantalla.Text + "7";
            }
        }

        private void ocho_Click(object sender, EventArgs e) {
            if (detectaopreacion) {
                txtpantalla.Text = "";
                txtpantalla.Text = "8";
                detectaopreacion = false;

            } else {
                txtpantalla.Text = txtpantalla.Text + "8";
            }
        }

        private void nueve_Click(object sender, EventArgs e) {
            if (detectaopreacion) {
                txtpantalla.Text = "";
                txtpantalla.Text = "9";
                detectaopreacion = false;

            } else {
                txtpantalla.Text = txtpantalla.Text + "9";
            }
        }


        // Botones cálculos
        private void dividir_Click(object sender, EventArgs e) {
            operacion = "/";
            detectaopreacion = true;
            numero1 = double.Parse(txtpantalla.Text);
        }

        private void multiplicar_Click(object sender, EventArgs e) {
            operacion = "*";
            detectaopreacion = true;
            numero1 = double.Parse(txtpantalla.Text);
        }

        private void restar_Click(object sender, EventArgs e) {
            operacion = "-";
            detectaopreacion = true;
            numero1 = double.Parse(txtpantalla.Text);
        }

        private void sumar_Click(object sender, EventArgs e) {
            operacion = "+";
            detectaopreacion = true;
            numero1 = double.Parse(txtpantalla.Text);
        }

        private void coma_Click(object sender, EventArgs e) {
            if (punto == true) {
                txtpantalla.Text = txtpantalla.Text + ".";
                punto = false;
            } else {
                return;
            }
            detectaopreacion = false;
        }
        private void igual_Click(object sender, EventArgs e) {
            numero2 = double.Parse(txtpantalla.Text);
            detectaopreacion = true;
            switch (operacion) {
                case "+":
                    result = numero1 + numero2;
                    txtpantalla.Text = result.ToString();
                    break;
                case "-":
                    result = numero1 - numero2;
                    txtpantalla.Text = result.ToString();
                    break;
                case "*":
                    result = numero1 * numero2;
                    txtpantalla.Text = result.ToString();
                    break;
                case "/":
                    result = numero1 / numero2;
                    txtpantalla.Text = result.ToString();
                    break;

            }
        }

        private void raizcuadrado_Click(object sender, EventArgs e) {
            numero1 = double.Parse(txtpantalla.Text);
            result = Math.Sqrt(numero1);
            txtpantalla.Text = result.ToString();
            detectaopreacion = true;
        }

        private void porcentaje_Click(object sender, EventArgs e) {
            numero1 = double.Parse(txtpantalla.Text);
            result = ((numero1 * numero2) / 100);
            txtpantalla.Text = result.ToString();
            detectaopreacion = true;
        }



        private void elevcuadrado_Click(object sender, EventArgs e) {
            numero1 = double.Parse(txtpantalla.Text);
            result = numero1 * numero1;
            txtpantalla.Text = result.ToString();
        }

        private void fracciones_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txtpantalla.Text);
            result = 1 / numero1;
            txtpantalla.Text = result.ToString();
        }

        // Botones borrar
        private void borrar_Click(object sender, EventArgs e) {
            int x = 0;
            int y = 0;
            borrado = txtpantalla.Text;
            point = txtpantalla.Text;
            x = borrado.Length - 1;
            y = point.Length - 1;
            point = point.Substring(y, 1);
            borrado = borrado.Substring(0, x);
            txtpantalla.Text = borrado;
            if (txtpantalla.Text == "") {
                txtpantalla.Text = "0";
                detectaopreacion = true;
            }
            if (txtpantalla.Text == "-") {
                txtpantalla.Text = "0";
                detectaopreacion = true;
            }
            if (point == ".") {
                punto = true;
            }
        }
        
        private void boenre_Click(object sender, EventArgs e) {
            txtpantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            detectaopreacion = true;
            punto = true;
        }



        private void cambiosigno_Click(object sender, EventArgs e)
        {
            Signos = double.Parse(txtpantalla.Text);
            Signos = Signos - (Signos * 2);
            txtpantalla.Text = Signos.ToString();
        }


        private void boulca_Click(object sender, EventArgs e) {
            txtpantalla.Text = "0";
            detectaopreacion = true;
            numero1 = 0;
            numero2 = 0;
            result = 0;
        }

      

       

    }
}
