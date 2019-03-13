namespace Soma_2_numero
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.txbSegundonumero = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblPrimeiroNumero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubitrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.ForeColor = System.Drawing.Color.Green;
            this.lblSegundoNumero.Location = new System.Drawing.Point(144, 194);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(125, 13);
            this.lblSegundoNumero.TabIndex = 1;
            this.lblSegundoNumero.Text = "Digite o segundo numero";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Green;
            this.lblMensagem.Location = new System.Drawing.Point(144, 271);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(58, 13);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.Color.Green;
            this.lblResultado.Location = new System.Drawing.Point(233, 271);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbPrimeiroNumero
            // 
            this.txbPrimeiroNumero.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbPrimeiroNumero.ForeColor = System.Drawing.Color.Green;
            this.txbPrimeiroNumero.Location = new System.Drawing.Point(145, 159);
            this.txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            this.txbPrimeiroNumero.Size = new System.Drawing.Size(119, 20);
            this.txbPrimeiroNumero.TabIndex = 4;
            // 
            // txbSegundonumero
            // 
            this.txbSegundonumero.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbSegundonumero.ForeColor = System.Drawing.Color.Green;
            this.txbSegundonumero.Location = new System.Drawing.Point(145, 210);
            this.txbSegundonumero.Name = "txbSegundonumero";
            this.txbSegundonumero.Size = new System.Drawing.Size(119, 20);
            this.txbSegundonumero.TabIndex = 5;
            // 
            // btnSomar
            // 
            this.btnSomar.ForeColor = System.Drawing.Color.Green;
            this.btnSomar.Location = new System.Drawing.Point(145, 236);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(25, 21);
            this.btnSomar.TabIndex = 6;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.AutoSize = true;
            this.lblPrimeiroNumero.ForeColor = System.Drawing.Color.Green;
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(144, 143);
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(120, 13);
            this.lblPrimeiroNumero.TabIndex = 7;
            this.lblPrimeiroNumero.Text = "Digite o primeiro numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(338, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "GOOD BOY";
            // 
            // btnSubitrair
            // 
            this.btnSubitrair.ForeColor = System.Drawing.Color.Green;
            this.btnSubitrair.Location = new System.Drawing.Point(176, 236);
            this.btnSubitrair.Name = "btnSubitrair";
            this.btnSubitrair.Size = new System.Drawing.Size(25, 21);
            this.btnSubitrair.TabIndex = 9;
            this.btnSubitrair.Text = "-";
            this.btnSubitrair.UseVisualStyleBackColor = true;
            this.btnSubitrair.Click += new System.EventHandler(this.btnSubitrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.ForeColor = System.Drawing.Color.Green;
            this.btnMultiplicar.Location = new System.Drawing.Point(207, 236);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(25, 21);
            this.btnMultiplicar.TabIndex = 10;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            this.btnDividir.ForeColor = System.Drawing.Color.Green;
            this.btnDividir.Location = new System.Drawing.Point(236, 236);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(25, 21);
            this.btnDividir.TabIndex = 11;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(414, 381);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubitrair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrimeiroNumero);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txbSegundonumero);
            this.Controls.Add(this.txbPrimeiroNumero);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblSegundoNumero);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmPrincipal";
            this.Text = "Calculo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txbPrimeiroNumero;
        private System.Windows.Forms.TextBox txbSegundonumero;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label lblPrimeiroNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubitrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
    }
}

