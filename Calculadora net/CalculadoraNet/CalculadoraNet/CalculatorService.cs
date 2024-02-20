using System;
using System.Data;

namespace CalculadoraNet
{
    public class CalculatorService
    {
        public double AnsValue { get; private set; }

        public CalculatorService()
        {
            AnsValue = double.NaN;
        }

        public void ResetAnsValue()
        {
            AnsValue = double.NaN;
        }

        public string ProcessExpression(string expression)
        {
            // Reemplazar "ANS" con el valor almacenado
            expression = expression.Replace("ANS", AnsValue.ToString());

            // Utilizar la clase DataTable para evaluar la expresión matemática
            DataTable table = new DataTable();
            var result = table.Compute(expression, "");

            // Actualizar el valor de AnsValue
            if (double.TryParse(result.ToString(), out double parsedResult))
            {
                AnsValue = parsedResult;
            }

            return $"{expression}\r\n\r\n {result}";
        }
       
    }
}
