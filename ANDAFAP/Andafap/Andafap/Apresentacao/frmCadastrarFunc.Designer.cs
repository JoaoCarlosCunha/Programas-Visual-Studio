namespace Andafap.Apresentacao
{
    partial class frmCadastrarFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarFunc));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvMostar = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnVoltar.Location = new System.Drawing.Point(499, 438);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(229, 65);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnCadastra
            // 
            this.btnCadastra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCadastra.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnCadastra.Location = new System.Drawing.Point(499, 286);
            this.btnCadastra.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(229, 65);
            this.btnCadastra.TabIndex = 1;
            this.btnCadastra.Text = "Cadastrar";
            this.btnCadastra.UseVisualStyleBackColor = false;
            this.btnCadastra.Click += new System.EventHandler(this.BtnCadastra_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(567, 162);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(144, 43);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Click += new System.EventHandler(this.LblSenha_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbSenha.Location = new System.Drawing.Point(499, 212);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(226, 29);
            this.txbSenha.TabIndex = 6;
            this.txbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbSenha.TextChanged += new System.EventHandler(this.TxbSenha_TextChanged);
            // 
            // txbNome
            // 
            this.txbNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbNome.BackColor = System.Drawing.Color.White;
            this.txbNome.Location = new System.Drawing.Point(499, 98);
            this.txbNome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(226, 29);
            this.txbNome.TabIndex = 5;
            this.txbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbNome.TextChanged += new System.EventHandler(this.TxbNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(574, 48);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(136, 43);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.LblNome_Click);
            // 
            // dgvMostar
            // 
            this.dgvMostar.AllowUserToAddRows = false;
            this.dgvMostar.AllowUserToDeleteRows = false;
            this.dgvMostar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostar.Location = new System.Drawing.Point(22, 48);
            this.dgvMostar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvMostar.Name = "dgvMostar";
            this.dgvMostar.ReadOnly = true;
            this.dgvMostar.Size = new System.Drawing.Size(436, 240);
            this.dgvMostar.TabIndex = 10;
            this.dgvMostar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMostar_CellContentClick);
            this.dgvMostar.DoubleClick += new System.EventHandler(this.DgvMostar_DoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnExcluir.Location = new System.Drawing.Point(499, 362);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(229, 65);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // frmCadastrarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(798, 515);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvMostar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastra);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "frmCadastrarFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Capacitação";
            this.Load += new System.EventHandler(this.FrmCadastrarFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvMostar;
        private System.Windows.Forms.Button btnExcluir;
    }
}