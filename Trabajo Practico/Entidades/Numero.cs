using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        double numero;

        Numero()
        {
            numero = 0;
        }

        private double validarNumero(string p_numero)
        {
            double aux_numero;
            double v_return = 0;

            if (double.TryParse(p_numero, out aux_numero))
            {
                v_return = aux_numero;
            }
            return v_return;
        }

        public void setNumero(string p_numero)
        {
            this.numero = validarNumero(p_numero);
        }

        private static bool EsBinario(string p_binario)
        {
            bool v_return = true;
            for (int i = 0; i < p_binario.Length; i++)
            {
                if (p_binario.Substring(i) != "0" && p_binario.Substring(i) != "1")
                {
                    v_return = false;
                    break;
                }
            }
            return v_return;
        }

        public static string binarioDecimal(string p_binary)
        {

            int num;
            string v_return = "Valor invalido";
            int binVal;
            int decVal = 0;
            int baseVal = 1;
            int rem;

            if (EsBinario(p_binary))
            {
                num = int.Parse(p_binary);
                binVal = num;
                while (num > 0)
                {
                    rem = num % 10;
                    decVal = decVal + rem * baseVal;
                    num = num / 10;
                    baseVal = baseVal * 2;
                }
                v_return = decVal.ToString();
            }
            return v_return;
        }

        public static string decimalBinario(int p_num)
        {
            int[] a = new int[10];
            int i;
            string v_return = "Valor invalido";

            for (i = 0; p_num > 0; i++)
            {
                a[i] = p_num % 2;
                p_num = p_num / 2;
            }
            for (i = i - 1; i >= 0; i--)
            {
                v_return = v_return + a[i];
            }
            return v_return;
        }

        public static double operator +(Numero p_numA, Numero p_numb)
        {
            return p_numA.numero + p_numb.numero;
        }
        public static double operator -(Numero p_numA, Numero p_numb)
        {
            return p_numA.numero - p_numb.numero;
        }
        public static double operator *(Numero p_numA, Numero p_numb)
        {
            return p_numA.numero * p_numb.numero;
        }
        public static double operator /(Numero p_numA, Numero p_numb)
        {
            double v_return;

            if (p_numb.numero == 0)
            {
                v_return = double.MinValue;
            }
            else
            {
                v_return = p_numA.numero / p_numb.numero;
            }
            return v_return;
        }
    }
}
