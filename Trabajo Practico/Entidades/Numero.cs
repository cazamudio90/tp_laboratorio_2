using System;
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

        private bool EsBinario(string p_binario)
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
    }
}
