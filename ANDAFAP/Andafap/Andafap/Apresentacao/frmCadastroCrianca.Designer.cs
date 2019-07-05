namespace Andafap.Apresentacao
{
    partial class frmCadastroCrianca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCrianca));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblDataNas = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbNascimento = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.txbResponsavel = new System.Windows.Forms.TextBox();
            this.txbEESCOLARIDADE = new System.Windows.Forms.TextBox();
            this.lblESCOLARIDADE = new System.Windows.Forms.Label();
            this.txbRGMAE = new System.Windows.Forms.TextBox();
            this.lblRGMAE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnVoltar.Location = new System.Drawing.Point(610, 530);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(224, 100);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnCadastrar.Location = new System.Drawing.Point(381, 530);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(218, 100);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblNome.Location = new System.Drawing.Point(13, 22);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(136, 43);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNome.Location = new System.Drawing.Point(405, 30);
            this.txbNome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(429, 29);
            this.txbNome.TabIndex = 0;
            this.txbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblIdade.Location = new System.Drawing.Point(18, 162);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(133, 43);
            this.lblIdade.TabIndex = 12;
            this.lblIdade.Text = "Idade:";
            // 
            // lblDataNas
            // 
            this.lblDataNas.AutoSize = true;
            this.lblDataNas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblDataNas.Location = new System.Drawing.Point(13, 238);
            this.lblDataNas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataNas.Name = "lblDataNas";
            this.lblDataNas.Size = new System.Drawing.Size(245, 43);
            this.lblDataNas.TabIndex = 13;
            this.lblDataNas.Text = "Nascimento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblNumero.Location = new System.Drawing.Point(13, 100);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(186, 43);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Telefone:";
            // 
            // txbIdade
            // 
            this.txbIdade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIdade.Location = new System.Drawing.Point(405, 174);
            this.txbIdade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(429, 29);
            this.txbIdade.TabIndex = 2;
            this.txbIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTelefone.Location = new System.Drawing.Point(405, 107);
            this.txbTelefone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(429, 29);
            this.txbTelefone.TabIndex = 1;
            this.txbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbNascimento
            // 
            this.txbNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNascimento.Location = new System.Drawing.Point(405, 238);
            this.txbNascimento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.Size = new System.Drawing.Size(429, 29);
            this.txbNascimento.TabIndex = 3;
            this.txbNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblEndereco.Location = new System.Drawing.Point(13, 299);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(205, 43);
            this.lblEndereco.TabIndex = 14;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEndereco.Location = new System.Drawing.Point(405, 306);
            this.txbEndereco.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(429, 29);
            this.txbEndereco.TabIndex = 4;
            this.txbEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblResponsavel.Location = new System.Drawing.Point(13, 360);
            this.lblResponsavel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(261, 43);
            this.lblResponsavel.TabIndex = 15;
            this.lblResponsavel.Text = "Responsavel:";
            // 
            // txbResponsavel
            // 
            this.txbResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbResponsavel.Location = new System.Drawing.Point(405, 367);
            this.txbResponsavel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbResponsavel.Name = "txbResponsavel";
            this.txbResponsavel.Size = new System.Drawing.Size(429, 29);
            this.txbResponsavel.TabIndex = 5;
            this.txbResponsavel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbEESCOLARIDADE
            // 
            this.txbEESCOLARIDADE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEESCOLARIDADE.Location = new System.Drawing.Point(405, 489);
            this.txbEESCOLARIDADE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbEESCOLARIDADE.Name = "txbEESCOLARIDADE";
            this.txbEESCOLARIDADE.Size = new System.Drawing.Size(429, 29);
            this.txbEESCOLARIDADE.TabIndex = 7;
            this.txbEESCOLARIDADE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblESCOLARIDADE
            // 
            this.lblESCOLARIDADE.AutoSize = true;
            this.lblESCOLARIDADE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblESCOLARIDADE.Location = new System.Drawing.Point(13, 482);
            this.lblESCOLARIDADE.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblESCOLARIDADE.Name = "lblESCOLARIDADE";
            this.lblESCOLARIDADE.Size = new System.Drawing.Size(268, 43);
            this.lblESCOLARIDADE.TabIndex = 17;
            this.lblESCOLARIDADE.Text = "Escolaridade:";
            // 
            // txbRGMAE
            // 
            this.txbRGMAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRGMAE.Location = new System.Drawing.Point(405, 428);
            this.txbRGMAE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbRGMAE.Name = "txbRGMAE";
            this.txbRGMAE.Size = new System.Drawing.Size(429, 29);
            this.txbRGMAE.TabIndex = 6;
            this.txbRGMAE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRGMAE
            // 
            this.lblRGMAE.AutoSize = true;
            this.lblRGMAE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblRGMAE.Location = new System.Drawing.Point(13, 421);
            this.lblRGMAE.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRGMAE.Name = "lblRGMAE";
            this.lblRGMAE.Size = new System.Drawing.Size(380, 43);
            this.lblRGMAE.TabIndex = 16;
            this.lblRGMAE.Text = "RG do Responsavel:";
            // 
            // frmCadastroCrianca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(913, 706);
            this.Controls.Add(this.txbEESCOLARIDADE);
            this.Controls.Add(this.lblESCOLARIDADE);
            this.Controls.Add(this.txbRGMAE);
            this.Controls.Add(this.lblRGMAE);
            this.Controls.Add(this.txbResponsavel);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txbNascimento);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDataNas);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "frmCadastroCrianca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Capacitação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblDataNas;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbNascimento;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.TextBox txbResponsavel;
        private System.Windows.Forms.TextBox txbEESCOLARIDADE;
        private System.Windows.Forms.Label lblESCOLARIDADE;
        private System.Windows.Forms.TextBox txbRGMAE;
        private System.Windows.Forms.Label lblRGMAE;
    }
}