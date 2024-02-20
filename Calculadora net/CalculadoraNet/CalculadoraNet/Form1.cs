using System;
using System.Data;
using System.Windows.Forms;
namespace CalculadoraNet
{
    public partial class Form1 : Form
    {
        private double ansValue = double.NaN;
        public Form1()
        {
            InitializeComponent();

            // Asignar eventos a los botones
            BtnEqual.Click += BtnEqual_Click;
            BtnC.Click += BtnC_Click;
            BtnUno.Click += BtnNumber_Click;
            BtnDos.Click += BtnNumber_Click;
            // Asignar eventos para otros botones...
            BtnTres.Click += BtnNumber_Click;
            BtnCuatro.Click += BtnNumber_Click;
            BtnCinco.Click += BtnNumber_Click;
            BtnSeis.Click += BtnNumber_Click;
            BtnSiete.Click += BtnNumber_Click;
            BtnOcho.Click += BtnNumber_Click;
            BtnNueve.Click += BtnNumber_Click;
            BtnCero.Click += BtnNumber_Click;
            BtnPunto.Click += BtnNumber_Click;

            BtnMas.Click += BtnOperator_Click;
            BrnMenos.Click += BtnOperator_Click;
            BtnMult.Click += BtnOperator_Click;
            BtnDiv.Click += BtnOperator_Click;

            // Asignar evento KeyPress al TextBox
            textBox1.KeyPress += TextBox1_KeyPress;

            //Asignar otros botones
            BtnAns.Click += BtnAns_Click;
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            // L�gica para el bot�n C (borrar)
            textBox1.Text = "";
        }
        private void BtnAns_Click(object sender, EventArgs e)
        {
            if (!double.IsNaN(ansValue))
            {
                // Si ansValue tiene un valor v�lido, mostrarlo en textBox1.Text
                textBox1.Text += "ANS";
            }
        }
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            // L�gica para los botones de n�meros
            // Por ejemplo, agregar el n�mero correspondiente al textBox1.Text
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }
        private void BtnOperator_Click(object sender, EventArgs e)
        {
            // L�gica para los botones de operadores (+, -, *, /)
            Button btn = (Button)sender;
            textBox1.Text += " " + btn.Text + " ";
        }
        
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la expresi�n desde textBox1.Text
                string expression = textBox1.Text;

                // Reemplazar "ANS" con el valor de ansValue en la expresi�n
                expression = expression.Replace("ANS", ansValue.ToString());

                // Utilizar la clase DataTable para evaluar la expresi�n matem�tica
                DataTable table = new DataTable();
                var result = table.Compute(expression, "");

                // Mostrar el resultado en textBox1.Text
                textBox1.Text = result.ToString();

                // Actualizar el valor de ansValue
                if (double.TryParse(result.ToString(), out double parsedResult))
                {
                    ansValue = parsedResult;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepci�n que pueda ocurrir durante el c�lculo
                textBox1.Text = "Error";
            }
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // L�gica para manejar el evento KeyPress en el TextBox
            // Puedes validar el car�cter ingresado y decidir si permitirlo o no
            // Permitir n�meros y el car�cter de punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Suprimir el car�cter
            }
            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && textBox1.Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Suprimir el car�cter
            }
        }
       
    }
}