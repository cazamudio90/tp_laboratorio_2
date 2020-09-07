using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
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
    }
}
