namespace Caminho_Minimo
{
    partial class frmGrafo
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
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbOrigem = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCusto = new System.Windows.Forms.RadioButton();
            this.rdDistancia = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ckFalha = new System.Windows.Forms.CheckBox();
            this.cmbFalha = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(12, 9);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(40, 13);
            this.lblOrigem.TabIndex = 0;
            this.lblOrigem.Text = "Origem";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(163, 9);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(470, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // cmbOrigem
            // 
            this.cmbOrigem.FormattingEnabled = true;
            this.cmbOrigem.Location = new System.Drawing.Point(15, 25);
            this.cmbOrigem.Name = "cmbOrigem";
            this.cmbOrigem.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigem.TabIndex = 3;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(166, 25);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCusto);
            this.groupBox1.Controls.Add(this.rdDistancia);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Análise";
            // 
            // rdCusto
            // 
            this.rdCusto.AutoSize = true;
            this.rdCusto.Location = new System.Drawing.Point(151, 19);
            this.rdCusto.Name = "rdCusto";
            this.rdCusto.Size = new System.Drawing.Size(52, 17);
            this.rdCusto.TabIndex = 7;
            this.rdCusto.Text = "Custo";
            this.rdCusto.UseVisualStyleBackColor = true;
            // 
            // rdDistancia
            // 
            this.rdDistancia.AutoSize = true;
            this.rdDistancia.Checked = true;
            this.rdDistancia.Location = new System.Drawing.Point(6, 19);
            this.rdDistancia.Name = "rdDistancia";
            this.rdDistancia.Size = new System.Drawing.Size(69, 17);
            this.rdDistancia.TabIndex = 6;
            this.rdDistancia.TabStop = true;
            this.rdDistancia.Text = "Distância";
            this.rdDistancia.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 115);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(250, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(12, 155);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(470, 212);
            this.txtResultado.TabIndex = 9;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(268, 115);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(214, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // ckFalha
            // 
            this.ckFalha.AutoSize = true;
            this.ckFalha.Location = new System.Drawing.Point(324, 25);
            this.ckFalha.Name = "ckFalha";
            this.ckFalha.Size = new System.Drawing.Size(69, 17);
            this.ckFalha.TabIndex = 11;
            this.ckFalha.Text = "Falha em";
            this.ckFalha.UseVisualStyleBackColor = true;
            this.ckFalha.CheckedChanged += new System.EventHandler(this.CkFalha_CheckedChanged);
            // 
            // cmbFalha
            // 
            this.cmbFalha.Enabled = false;
            this.cmbFalha.FormattingEnabled = true;
            this.cmbFalha.Location = new System.Drawing.Point(392, 25);
            this.cmbFalha.Name = "cmbFalha";
            this.cmbFalha.Size = new System.Drawing.Size(90, 21);
            this.cmbFalha.TabIndex = 12;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(494, 400);
            this.Controls.Add(this.cmbFalha);
            this.Controls.Add(this.ckFalha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbOrigem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigem);
            this.Name = "frmGrafo";
            this.Text = "Caminho Mínimo - Dijkstra";
            this.Load += new System.EventHandler(this.FrmGrafo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cmbOrigem;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCusto;
        private System.Windows.Forms.RadioButton rdDistancia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckBox ckFalha;
        private System.Windows.Forms.ComboBox cmbFalha;
    }
}