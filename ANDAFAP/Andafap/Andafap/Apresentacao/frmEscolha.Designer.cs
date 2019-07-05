namespace Andafap.Apresentacao
{
    partial class frmEscolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscolha));
            this.mnsFormularios = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarCriançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsFormularios
            // 
            this.mnsFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mnsFormularios.BackColor = System.Drawing.Color.Transparent;
            this.mnsFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnsFormularios.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsFormularios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.mnsFormularios.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnsFormularios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pesquisarCriançaToolStripMenuItem,
            this.trocarDeLoginToolStripMenuItem});
            this.mnsFormularios.Location = new System.Drawing.Point(9, 134);
            this.mnsFormularios.Name = "mnsFormularios";
            this.mnsFormularios.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.mnsFormularios.Size = new System.Drawing.Size(499, 36);
            this.mnsFormularios.TabIndex = 1;
            this.mnsFormularios.Text = "Menu Formularios";
            this.mnsFormularios.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MnsFormularios_ItemClicked);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem,
            this.criançaToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(203, 28);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.FuncionarioToolStripMenuItem_Click);
            // 
            // criançaToolStripMenuItem
            // 
            this.criançaToolStripMenuItem.Name = "criançaToolStripMenuItem";
            this.criançaToolStripMenuItem.Size = new System.Drawing.Size(203, 28);
            this.criançaToolStripMenuItem.Text = "Criança";
            this.criançaToolStripMenuItem.Click += new System.EventHandler(this.CriançaToolStripMenuItem_Click);
            // 
            // pesquisarCriançaToolStripMenuItem
            // 
            this.pesquisarCriançaToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarCriançaToolStripMenuItem.Name = "pesquisarCriançaToolStripMenuItem";
            this.pesquisarCriançaToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.pesquisarCriançaToolStripMenuItem.Text = "Motivo da Visita";
            this.pesquisarCriançaToolStripMenuItem.Click += new System.EventHandler(this.PesquisarCriançaToolStripMenuItem_Click);
            // 
            // trocarDeLoginToolStripMenuItem
            // 
            this.trocarDeLoginToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.trocarDeLoginToolStripMenuItem.Name = "trocarDeLoginToolStripMenuItem";
            this.trocarDeLoginToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.trocarDeLoginToolStripMenuItem.Text = "Trocar de Login";
            this.trocarDeLoginToolStripMenuItem.Click += new System.EventHandler(this.TrocarDeLoginToolStripMenuItem_Click);
            // 
            // frmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 301);
            this.Controls.Add(this.mnsFormularios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEscolha";
            this.Text = "Centro de Capacitação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsFormularios.ResumeLayout(false);
            this.mnsFormularios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsFormularios;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarCriançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarDeLoginToolStripMenuItem;
    }
}