namespace Andafap.Apresentacao
{
    partial class frmoqfazer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmoqfazer));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvMostar = new System.Windows.Forms.DataGridView();
            this.txbEESCOLARIDADE = new System.Windows.Forms.TextBox();
            this.lblESCOLARIDADE = new System.Windows.Forms.Label();
            this.txbRGMAE = new System.Windows.Forms.TextBox();
            this.lblRGMAE = new System.Windows.Forms.Label();
            this.txbResponsavel = new System.Windows.Forms.TextBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbNascimento = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDataNas = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAtividades = new System.Windows.Forms.Label();
            this.txbAtividade = new System.Windows.Forms.TextBox();
            this.btnAtividade = new System.Windows.Forms.Button();
            this.lblAtividade = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnVoltar.Location = new System.Drawing.Point(896, 923);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(235, 78);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // dgvMostar
            // 
            this.dgvMostar.AllowUserToAddRows = false;
            this.dgvMostar.AllowUserToDeleteRows = false;
            this.dgvMostar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostar.Location = new System.Drawing.Point(6, 24);
            this.dgvMostar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvMostar.Name = "dgvMostar";
            this.dgvMostar.ReadOnly = true;
            this.dgvMostar.Size = new System.Drawing.Size(1095, 358);
            this.dgvMostar.TabIndex = 9;
            this.dgvMostar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMostar_CellContentClick);
            this.dgvMostar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMostar_CellDoubleClick);
            // 
            // txbEESCOLARIDADE
            // 
            this.txbEESCOLARIDADE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEESCOLARIDADE.Location = new System.Drawing.Point(502, 866);
            this.txbEESCOLARIDADE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbEESCOLARIDADE.Name = "txbEESCOLARIDADE";
            this.txbEESCOLARIDADE.Size = new System.Drawing.Size(567, 29);
            this.txbEESCOLARIDADE.TabIndex = 31;
            this.txbEESCOLARIDADE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblESCOLARIDADE
            // 
            this.lblESCOLARIDADE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblESCOLARIDADE.AutoSize = true;
            this.lblESCOLARIDADE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblESCOLARIDADE.Location = new System.Drawing.Point(26, 858);
            this.lblESCOLARIDADE.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblESCOLARIDADE.Name = "lblESCOLARIDADE";
            this.lblESCOLARIDADE.Size = new System.Drawing.Size(268, 43);
            this.lblESCOLARIDADE.TabIndex = 33;
            this.lblESCOLARIDADE.Text = "Escolaridade:";
            // 
            // txbRGMAE
            // 
            this.txbRGMAE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbRGMAE.Location = new System.Drawing.Point(502, 805);
            this.txbRGMAE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbRGMAE.Name = "txbRGMAE";
            this.txbRGMAE.Size = new System.Drawing.Size(567, 29);
            this.txbRGMAE.TabIndex = 30;
            this.txbRGMAE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRGMAE
            // 
            this.lblRGMAE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRGMAE.AutoSize = true;
            this.lblRGMAE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblRGMAE.Location = new System.Drawing.Point(26, 798);
            this.lblRGMAE.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRGMAE.Name = "lblRGMAE";
            this.lblRGMAE.Size = new System.Drawing.Size(380, 43);
            this.lblRGMAE.TabIndex = 32;
            this.lblRGMAE.Text = "RG do Responsavel:";
            // 
            // txbResponsavel
            // 
            this.txbResponsavel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbResponsavel.Location = new System.Drawing.Point(502, 744);
            this.txbResponsavel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbResponsavel.Name = "txbResponsavel";
            this.txbResponsavel.Size = new System.Drawing.Size(560, 29);
            this.txbResponsavel.TabIndex = 23;
            this.txbResponsavel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblResponsavel.Location = new System.Drawing.Point(26, 737);
            this.lblResponsavel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(261, 43);
            this.lblResponsavel.TabIndex = 29;
            this.lblResponsavel.Text = "Responsavel:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEndereco.Location = new System.Drawing.Point(502, 683);
            this.txbEndereco.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(560, 29);
            this.txbEndereco.TabIndex = 22;
            this.txbEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblEndereco.Location = new System.Drawing.Point(26, 676);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(205, 43);
            this.lblEndereco.TabIndex = 28;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txbNascimento
            // 
            this.txbNascimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbNascimento.Location = new System.Drawing.Point(502, 615);
            this.txbNascimento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.Size = new System.Drawing.Size(552, 29);
            this.txbNascimento.TabIndex = 21;
            this.txbNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbTelefone.Location = new System.Drawing.Point(502, 484);
            this.txbTelefone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(552, 29);
            this.txbTelefone.TabIndex = 19;
            this.txbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbIdade
            // 
            this.txbIdade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbIdade.Location = new System.Drawing.Point(502, 550);
            this.txbIdade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(552, 29);
            this.txbIdade.TabIndex = 20;
            this.txbIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblNumero.Location = new System.Drawing.Point(26, 476);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(186, 43);
            this.lblNumero.TabIndex = 25;
            this.lblNumero.Text = "Telefone:";
            // 
            // lblDataNas
            // 
            this.lblDataNas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataNas.AutoSize = true;
            this.lblDataNas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblDataNas.Location = new System.Drawing.Point(26, 615);
            this.lblDataNas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataNas.Name = "lblDataNas";
            this.lblDataNas.Size = new System.Drawing.Size(245, 43);
            this.lblDataNas.TabIndex = 27;
            this.lblDataNas.Text = "Nascimento:";
            // 
            // lblIdade
            // 
            this.lblIdade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblIdade.Location = new System.Drawing.Point(29, 537);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(133, 43);
            this.lblIdade.TabIndex = 26;
            this.lblIdade.Text = "Idade:";
            // 
            // txbNome
            // 
            this.txbNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbNome.Location = new System.Drawing.Point(502, 406);
            this.txbNome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(552, 29);
            this.txbNome.TabIndex = 18;
            this.txbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblNome.Location = new System.Drawing.Point(26, 399);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(136, 43);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome:";
            // 
            // lblAtividades
            // 
            this.lblAtividades.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAtividades.AutoSize = true;
            this.lblAtividades.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblAtividades.Location = new System.Drawing.Point(1483, 24);
            this.lblAtividades.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAtividades.Name = "lblAtividades";
            this.lblAtividades.Size = new System.Drawing.Size(189, 43);
            this.lblAtividades.TabIndex = 34;
            this.lblAtividades.Text = "Atividade";
            // 
            // txbAtividade
            // 
            this.txbAtividade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbAtividade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbAtividade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txbAtividade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbAtividade.Location = new System.Drawing.Point(1200, 74);
            this.txbAtividade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbAtividade.Multiline = true;
            this.txbAtividade.Name = "txbAtividade";
            this.txbAtividade.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbAtividade.Size = new System.Drawing.Size(638, 643);
            this.txbAtividade.TabIndex = 35;
            this.txbAtividade.TabStop = false;
            this.txbAtividade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbAtividade.WordWrap = false;
            this.txbAtividade.TextChanged += new System.EventHandler(this.TxbAtividade_TextChanged);
            // 
            // btnAtividade
            // 
            this.btnAtividade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtividade.BackColor = System.Drawing.Color.Transparent;
            this.btnAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtividade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnAtividade.Location = new System.Drawing.Point(327, 924);
            this.btnAtividade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtividade.Name = "btnAtividade";
            this.btnAtividade.Size = new System.Drawing.Size(235, 79);
            this.btnAtividade.TabIndex = 36;
            this.btnAtividade.Text = "Excluir";
            this.btnAtividade.UseVisualStyleBackColor = false;
            this.btnAtividade.Click += new System.EventHandler(this.BtnAtividade_Click);
            // 
            // lblAtividade
            // 
            this.lblAtividade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblAtividade.Location = new System.Drawing.Point(1443, 166);
            this.lblAtividade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(0, 43);
            this.lblAtividade.TabIndex = 37;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnCadastrar.Location = new System.Drawing.Point(584, 922);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(279, 79);
            this.btnCadastrar.TabIndex = 38;
            this.btnCadastrar.Text = "Limpar Tela";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.button1.Location = new System.Drawing.Point(34, 922);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 79);
            this.button1.TabIndex = 39;
            this.button1.Text = "Colocar Ativ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmoqfazer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1896, 1016);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblAtividade);
            this.Controls.Add(this.btnAtividade);
            this.Controls.Add(this.txbAtividade);
            this.Controls.Add(this.lblAtividades);
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
            this.Controls.Add(this.dgvMostar);
            this.Controls.Add(this.btnVoltar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "frmoqfazer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Capacitação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmoqfazer_Load);
            this.Click += new System.EventHandler(this.Frmoqfazer_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvMostar;
        private System.Windows.Forms.TextBox txbEESCOLARIDADE;
        private System.Windows.Forms.Label lblESCOLARIDADE;
        private System.Windows.Forms.TextBox txbRGMAE;
        private System.Windows.Forms.Label lblRGMAE;
        private System.Windows.Forms.TextBox txbResponsavel;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbNascimento;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDataNas;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAtividades;
        private System.Windows.Forms.TextBox txbAtividade;
        private System.Windows.Forms.Button btnAtividade;
        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button button1;
    }
}