using System;
using System.Data;
using System.Windows.Forms;
namespace CalculadoraNet
{
    public partial class Form1 : Form
    {
        private double ansValue = double.NaN;
        private bool resultadoMostrado = false;
        private bool ansUtilizado = false;

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
            BtnPar1.Click += BtnOperator_Click;
            BtnPar2.Click += BtnOperator_Click;


            // Asignar evento KeyPress al TextBox
            richTextBox1.KeyPress += RichTextBox1_KeyPress;

            //Asignar otros botones
            BtnAns.Click += BtnAns_Click;
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            // Lógica para el botón C (borrar)
            richTextBox1.Text = "";
            ansValue = double.NaN;
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            // Lógica para los botones de números
            // Por ejemplo, agregar el número correspondiente al richTextBox1.Text
            if (resultadoMostrado)
            {
                // Si el resultado está mostrado, comenzar una nueva operación
                richTextBox1.Text = "";
                resultadoMostrado = false;
            }

            Button btn = (Button)sender;
            richTextBox1.Text += btn.Text;
        }

        private void BtnOperator_Click(object sender, EventArgs e)
        {
            // Lógica para los botones de operadores (+, -, *, /)
            Button btn = (Button)sender;
            richTextBox1.Text += " " + btn.Text + " ";
        }
        private void BtnAns_Click(object sender, EventArgs e)
        {
            if (!double.IsNaN(ansValue))
            {
                if (resultadoMostrado)
                {
                    // Si el resultado está mostrado, comenzar una nueva operación
                    richTextBox1.Text = "";
                    resultadoMostrado = false;
                }

                richTextBox1.Text += "ANS";
                ansUtilizado = true;
            }
        }
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la expresión desde richTextBox1.Text
                string expression = richTextBox1.Text;

                // Reemplazar "ANS" con el valor almacenado
                expression = expression.Replace("ANS", ansValue.ToString());

                // Utilizar la clase DataTable para evaluar la expresión matemática
                DataTable table = new DataTable();
                var result = table.Compute(expression, "");

                // Mostrar el resultado en richTextBox1.Text
                richTextBox1.Text = $"{expression}\r\n\r\nResultado: {result}";

                // Actualizar el valor de ansValue
                if (double.TryParse(result.ToString(), out double parsedResult))
                {
                    ansValue = parsedResult;
                }

                // Actualizar el estado de resultadoMostrado
                resultadoMostrado = true;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el cálculo
                richTextBox1.Text = "Error";
                ansValue = double.NaN;
                resultadoMostrado = true;
            }
        }

        private void RichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Lógica para manejar el evento KeyPress en el RichTextBox
            // Puedes validar el carácter ingresado y decidir si permitirlo o no
            // Permitir números y el carácter de punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Suprimir el carácter
            }
            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && richTextBox1.Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Suprimir el carácter
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Lógica para manejar el evento KeyPress en el formulario
            // Puedes asignar acciones a teclas específicas si lo deseas
            // En este ejemplo, permitir que Enter actúe como el botón de igual
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnEqual.PerformClick();
            }
        }
    }
}