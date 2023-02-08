namespace Caminho_Minimo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enalcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminhoMínimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.caminhoMínimoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadesToolStripMenuItem,
            this.enalcesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cidadesToolStripMenuItem
            // 
            this.cidadesToolStripMenuItem.Name = "cidadesToolStripMenuItem";
            this.cidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cidadesToolStripMenuItem.Text = "Cidades";
            this.cidadesToolStripMenuItem.Click += new System.EventHandler(this.CidadesToolStripMenuItem_Click);
            // 
            // enalcesToolStripMenuItem
            // 
            this.enalcesToolStripMenuItem.Name = "enalcesToolStripMenuItem";
            this.enalcesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.enalcesToolStripMenuItem.Text = "Enalces";
            // 
            // caminhoMínimoToolStripMenuItem
            // 
            this.caminhoMínimoToolStripMenuItem.Name = "caminhoMínimoToolStripMenuItem";
            this.caminhoMínimoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.caminhoMínimoToolStripMenuItem.Text = "Caminho Mínimo";
            this.caminhoMínimoToolStripMenuItem.Click += new System.EventHandler(this.CaminhoMínimoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 65);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Caminho Mínimo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enalcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminhoMínimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

