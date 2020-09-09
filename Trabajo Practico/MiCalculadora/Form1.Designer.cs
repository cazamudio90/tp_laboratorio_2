namespace MiCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cbOperaciones = new System.Windows.Forms.ComboBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvBinario = new System.Windows.Forms.Button();
            this.btnConvDecimal = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(167, 76);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(102, 62);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(563, 76);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(102, 62);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbOperaciones
            // 
            this.cbOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperaciones.FormattingEnabled = true;
            this.cbOperaciones.ItemHeight = 55;
            this.cbOperaciones.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cbOperaciones.Location = new System.Drawing.Point(365, 76);
            this.cbOperaciones.Name = "cbOperaciones";
            this.cbOperaciones.Size = new System.Drawing.Size(102, 63);
            this.cbOperaciones.TabIndex = 2;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(123, 153);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(146, 52);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(343, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(146, 52);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(563, 153);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(146, 52);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvBinario
            // 
            this.btnConvBinario.Location = new System.Drawing.Point(207, 230);
            this.btnConvBinario.Name = "btnConvBinario";
            this.btnConvBinario.Size = new System.Drawing.Size(146, 52);
            this.btnConvBinario.TabIndex = 6;
            this.btnConvBinario.Text = "Convertir a Binario";
            this.btnConvBinario.UseVisualStyleBackColor = true;
            this.btnConvBinario.Click += new System.EventHandler(this.btnConvBinario_Click);
            // 
            // btnConvDecimal
            // 
            this.btnConvDecimal.Location = new System.Drawing.Point(454, 230);
            this.btnConvDecimal.Name = "btnConvDecimal";
            this.btnConvDecimal.Size = new System.Drawing.Size(146, 52);
            this.btnConvDecimal.TabIndex = 7;
            this.btnConvDecimal.Text = "Convertir a Decimal";
            this.btnConvDecimal.UseVisualStyleBackColor = true;
            this.btnConvDecimal.Click += new System.EventHandler(this.btnConvDecimal_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(640, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 55);
            this.lblResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 359);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvDecimal);
            this.Controls.Add(this.btnConvBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.cbOperaciones);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora de Carlos Zamudio 2°D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox cbOperaciones;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvBinario;
        private System.Windows.Forms.Button btnConvDecimal;
        private System.Windows.Forms.Label lblResultado;
    }
}

