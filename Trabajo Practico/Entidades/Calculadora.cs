using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static string ValidarOperador(char p_operador)
        {
            string v_return;

            switch (p_operador)
            {
                case '+':
                    v_return = "+";
                    break;
                case '-':
                    v_return = "-";
                    break;
                case '*':
                    v_return = "*";
                    break;
                case '/':
                    v_return = "/";
                    break;
                default:
                    v_return = "+";
                    break;
            }
            return v_return;
        }

        public static double Operar(Numero p_num1, Numero p_num2, string p_operador)
        {
            double v_return = 0;
            char valid_op;
            if (char.TryParse(p_operador, out valid_op))
            {
                switch (ValidarOperador(valid_op))
                {
                    case "+":
                        v_return = p_num1 + p_num2;
                        break;
                    case "-":
                        v_return = p_num1 - p_num2;
                        break;
                    case "*":
                        v_return = p_num1 * p_num2;
                        break;
                    case "/":
                        v_return = p_num1 / p_num2;
                        break;
                }
            }
            return v_return;
        }
    }
}
