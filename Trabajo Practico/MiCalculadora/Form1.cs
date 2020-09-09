using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double v_resultado;
            Numero num1 = new Numero();
            Numero num2 = new Numero();
            string operacion = this.cbOperaciones.SelectedItem.ToString();
            num1.SetNumero(this.txtNum1.Text);
            num2.SetNumero(this.txtNum2.Text);


            v_resultado = Calculadora.Operar(num1, num2, operacion);

            this.lblResultado.Text = v_resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNum1.Text = null;
            this.txtNum2.Text = null;
            this.cbOperaciones.SelectedItem = null;
            this.lblResultado.Text = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvBinario_Click(object sender, EventArgs e)
        {
            string v_decimal = this.lblResultado.Text;
            string v_resultado = null;
            int aux_num;

            if ( int.TryParse(v_decimal, out aux_num))
            {
                v_resultado = Numero.DecimalBinario(aux_num);
            }
            this.lblResultado.Text = v_resultado;
        }

        private void btnConvDecimal_Click(object sender, EventArgs e)
        {
            string v_binario = this.lblResultado.Text;
            string v_resultado;

            v_resultado = Numero.BinarioDecimal(v_binario);
            this.lblResultado.Text = v_resultado;
        }
    }
}
