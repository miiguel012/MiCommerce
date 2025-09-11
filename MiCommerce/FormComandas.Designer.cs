namespace MiCommerce
{
    partial class FormComandas
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
            this.grbComandas = new System.Windows.Forms.GroupBox();
            this.lblComandaInformacoes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbComandaInformacoes = new System.Windows.Forms.TextBox();
            this.txbprodutoinformacoes = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.grbLancamentoscomandas = new System.Windows.Forms.GroupBox();
            this.lblprodutolancamento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbProdutoLancamento = new System.Windows.Forms.TextBox();
            this.txbquantidadeLancamentos = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbComandas.SuspendLayout();
            this.grbLancamentoscomandas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbComandas
            // 
            this.grbComandas.Controls.Add(this.btnContinuar);
            this.grbComandas.Controls.Add(this.txbprodutoinformacoes);
            this.grbComandas.Controls.Add(this.txbComandaInformacoes);
            this.grbComandas.Controls.Add(this.label2);
            this.grbComandas.Controls.Add(this.lblComandaInformacoes);
            this.grbComandas.Location = new System.Drawing.Point(33, 12);
            this.grbComandas.Name = "grbComandas";
            this.grbComandas.Size = new System.Drawing.Size(248, 190);
            this.grbComandas.TabIndex = 0;
            this.grbComandas.TabStop = false;
            this.grbComandas.Text = "Informaçoes";
            // 
            // lblComandaInformacoes
            // 
            this.lblComandaInformacoes.AutoSize = true;
            this.lblComandaInformacoes.Location = new System.Drawing.Point(32, 39);
            this.lblComandaInformacoes.Name = "lblComandaInformacoes";
            this.lblComandaInformacoes.Size = new System.Drawing.Size(61, 13);
            this.lblComandaInformacoes.TabIndex = 0;
            this.lblComandaInformacoes.Text = "COMANDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRODUTO:";
            // 
            // txbComandaInformacoes
            // 
            this.txbComandaInformacoes.Location = new System.Drawing.Point(114, 31);
            this.txbComandaInformacoes.Name = "txbComandaInformacoes";
            this.txbComandaInformacoes.Size = new System.Drawing.Size(100, 20);
            this.txbComandaInformacoes.TabIndex = 2;
            // 
            // txbprodutoinformacoes
            // 
            this.txbprodutoinformacoes.Location = new System.Drawing.Point(114, 94);
            this.txbprodutoinformacoes.Name = "txbprodutoinformacoes";
            this.txbprodutoinformacoes.Size = new System.Drawing.Size(100, 20);
            this.txbprodutoinformacoes.TabIndex = 3;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(47, 134);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(129, 37);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // grbLancamentoscomandas
            // 
            this.grbLancamentoscomandas.Controls.Add(this.txbquantidadeLancamentos);
            this.grbLancamentoscomandas.Controls.Add(this.txbProdutoLancamento);
            this.grbLancamentoscomandas.Controls.Add(this.btnLancar);
            this.grbLancamentoscomandas.Controls.Add(this.label3);
            this.grbLancamentoscomandas.Controls.Add(this.lblprodutolancamento);
            this.grbLancamentoscomandas.Enabled = false;
            this.grbLancamentoscomandas.Location = new System.Drawing.Point(33, 238);
            this.grbLancamentoscomandas.Name = "grbLancamentoscomandas";
            this.grbLancamentoscomandas.Size = new System.Drawing.Size(227, 187);
            this.grbLancamentoscomandas.TabIndex = 1;
            this.grbLancamentoscomandas.TabStop = false;
            this.grbLancamentoscomandas.Text = "Lançamentos";
            // 
            // lblprodutolancamento
            // 
            this.lblprodutolancamento.AutoSize = true;
            this.lblprodutolancamento.Location = new System.Drawing.Point(21, 34);
            this.lblprodutolancamento.Name = "lblprodutolancamento";
            this.lblprodutolancamento.Size = new System.Drawing.Size(61, 13);
            this.lblprodutolancamento.TabIndex = 0;
            this.lblprodutolancamento.Text = "PRODUTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "QUANTIDADE";
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(35, 116);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(104, 44);
            this.btnLancar.TabIndex = 2;
            this.btnLancar.Text = "LANÇAR";
            this.btnLancar.UseVisualStyleBackColor = true;
            // 
            // txbProdutoLancamento
            // 
            this.txbProdutoLancamento.Location = new System.Drawing.Point(102, 26);
            this.txbProdutoLancamento.Name = "txbProdutoLancamento";
            this.txbProdutoLancamento.Size = new System.Drawing.Size(100, 20);
            this.txbProdutoLancamento.TabIndex = 3;
            // 
            // txbquantidadeLancamentos
            // 
            this.txbquantidadeLancamentos.Location = new System.Drawing.Point(106, 65);
            this.txbquantidadeLancamentos.Name = "txbquantidadeLancamentos";
            this.txbquantidadeLancamentos.Size = new System.Drawing.Size(100, 20);
            this.txbquantidadeLancamentos.TabIndex = 4;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(400, 109);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(240, 275);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(367, 67);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 24);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Lancamentos de Comandas";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::MiCommerce.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(619, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbLancamentoscomandas);
            this.Controls.Add(this.grbComandas);
            this.MaximizeBox = false;
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComandas";
            this.Load += new System.EventHandler(this.FormComandas_Load);
            this.grbComandas.ResumeLayout(false);
            this.grbComandas.PerformLayout();
            this.grbLancamentoscomandas.ResumeLayout(false);
            this.grbLancamentoscomandas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbComandas;
        private System.Windows.Forms.TextBox txbprodutoinformacoes;
        private System.Windows.Forms.TextBox txbComandaInformacoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblComandaInformacoes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.GroupBox grbLancamentoscomandas;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblprodutolancamento;
        private System.Windows.Forms.TextBox txbquantidadeLancamentos;
        private System.Windows.Forms.TextBox txbProdutoLancamento;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}