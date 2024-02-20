using System;
using System.Data;
using System.Windows.Forms;

namespace CalculadoraNet
{
    public partial class Form1 : Form
    {
        private readonly CalculatorService calculatorService;
        private bool resultadoMostrado = false;
        private bool ansUtilizado = false;

        public Form1()
        {
            InitializeComponent();

            // Inicializar el servicio de la calculadora
            calculatorService = new CalculatorService();

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

            // Asignar evento KeyPress al TextBox y al formulario
            //richTextBox1.KeyPress += RichTextBox1_KeyPress;
            KeyPress += Form1_KeyPress;

            // Asignar otros botones
            BtnAns.Click += BtnAns_Click;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            // Lógica para el botón C (borrar)
            richTextBox1.Text = "";
            calculatorService.ResetAnsValue();
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
            if (!double.IsNaN(calculatorService.AnsValue))
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

                // Procesar la expresión con el servicio de la calculadora
                string result = calculatorService.ProcessExpression(expression);

                // Mostrar el resultado en richTextBox1.Text
                richTextBox1.Text = result;

                // Actualizar el estado de resultadoMostrado
                resultadoMostrado = true;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el cálculo
                richTextBox1.Text = "Error";
                calculatorService.ResetAnsValue();
                resultadoMostrado = true;
            }
        }

        private void RichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Lógica para manejar el evento KeyPress en el RichTextBox
            // Puedes validar el carácter ingresado y decidir si permitirlo o no
            if (!char.IsControl(e.KeyChar))
            {
                HandleKeyPress(e.KeyChar);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Lógica para manejar el evento KeyPress en el formulario
            if (!char.IsControl(e.KeyChar))
            {
                HandleKeyPress(e.KeyChar);
                e.Handled = true; // Suprimir el carácter original
            }
        }

        private void HandleKeyPress(char keyPressed)
        {
            // Lógica para manejar el evento KeyPress en el formulario
            if (char.IsDigit(keyPressed))
            {
                HandleDigitKeyPress(keyPressed);
            }
            else if (keyPressed == '.' && richTextBox1.Text.IndexOf('.') == -1)
            {
                HandleDecimalKeyPress(keyPressed);
            }
            else if (keyPressed == (char)Keys.Back && richTextBox1.Text.Length > 0)
            {
                HandleBackspaceKeyPress();
            }
            else if (keyPressed == (char)Keys.Enter)
            {
                HandleEnterKeyPress();
            }
            else if (IsOperatorKey(keyPressed))
            {
                HandleOperatorKeyPress(keyPressed);
            }
            else if (IsParenthesisKey(keyPressed))
            {
                HandleParenthesisKeyPress(keyPressed);
            }
            else if (IsTrigonometricFunctionKey(keyPressed))
            {
                HandleTrigonometricFunctionKeyPress(keyPressed);
            }
        }

        private void HandleDigitKeyPress(char digit)
        {
            // Si es un dígito, agregar al richTextBox1.Text
            richTextBox1.Text += digit;
        }

        private void HandleDecimalKeyPress(char dot)
        {
            // Permitir solo un punto decimal
            richTextBox1.Text += dot;
        }

        private void HandleBackspaceKeyPress()
        {
            // Permitir retroceder para borrar
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
        }

        private void HandleEnterKeyPress()
        {
            // Al presionar Enter, realizar la acción del botón igual
            BtnEqual.PerformClick();
        }

        private bool IsOperatorKey(char key)
        {
            return key == '+' || key == '-' || key == '*' || key == '/';
        }

        private void HandleOperatorKeyPress(char operatorKey)
        {
            // Agregar operadores al richTextBox1.Text
            richTextBox1.Text += " " + operatorKey + " ";
        }

        private bool IsParenthesisKey(char key)
        {
            return key == '(' || key == ')';
        }

        private void HandleParenthesisKeyPress(char parenthesis)
        {
            // Agregar paréntesis al richTextBox1.Text
            richTextBox1.Text += parenthesis;
        }

        private bool IsTrigonometricFunctionKey(char key)
        {
            return key == 's' || key == 'c' || key == 't';
        }

        private void HandleTrigonometricFunctionKeyPress(char functionKey)
        {
            // Ejemplo: Teclas s, c, t para funciones trigonométricas
            richTextBox1.Text += functionKey;
        }
    }
}
