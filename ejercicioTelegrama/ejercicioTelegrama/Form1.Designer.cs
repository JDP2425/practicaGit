namespace ejercicioTelegrama
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.lblCoste = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.pnlTipo = new System.Windows.Forms.Panel();
            this.radOrdinario = new System.Windows.Forms.RadioButton();
            this.radUrgente = new System.Windows.Forms.RadioButton();
            this.pnlTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEXTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(59, 224);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(86, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(310, 227);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(95, 41);
            this.btnCalcularPrecio.TabIndex = 5;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Location = new System.Drawing.Point(19, 227);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(34, 13);
            this.lblCoste.TabIndex = 6;
            this.lblCoste.Text = "Coste";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(32, 54);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(509, 61);
            this.txtTelegrama.TabIndex = 7;
            // 
            // pnlTipo
            // 
            this.pnlTipo.Controls.Add(this.radUrgente);
            this.pnlTipo.Controls.Add(this.radOrdinario);
            this.pnlTipo.Location = new System.Drawing.Point(32, 169);
            this.pnlTipo.Name = "pnlTipo";
            this.pnlTipo.Size = new System.Drawing.Size(306, 32);
            this.pnlTipo.TabIndex = 8;
            // 
            // radOrdinario
            // 
            this.radOrdinario.AutoSize = true;
            this.radOrdinario.Location = new System.Drawing.Point(10, 12);
            this.radOrdinario.Name = "radOrdinario";
            this.radOrdinario.Size = new System.Drawing.Size(67, 17);
            this.radOrdinario.TabIndex = 0;
            this.radOrdinario.TabStop = true;
            this.radOrdinario.Text = "Ordinario";
            this.radOrdinario.UseVisualStyleBackColor = true;
            // 
            // radUrgente
            // 
            this.radUrgente.AutoSize = true;
            this.radUrgente.Location = new System.Drawing.Point(131, 12);
            this.radUrgente.Name = "radUrgente";
            this.radUrgente.Size = new System.Drawing.Size(63, 17);
            this.radUrgente.TabIndex = 1;
            this.radUrgente.TabStop = true;
            this.radUrgente.Text = "Urgente";
            this.radUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTipo);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlTipo.ResumeLayout(false);
            this.pnlTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Panel pnlTipo;
        private System.Windows.Forms.RadioButton radUrgente;
        private System.Windows.Forms.RadioButton radOrdinario;
    }
}

