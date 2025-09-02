namespace MiCommerce
{
    partial class FormUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmailCadastro = new System.Windows.Forms.Label();
            this.txbEmailCadastro = new System.Windows.Forms.TextBox();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.txbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbSenhaEditar = new System.Windows.Forms.TextBox();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.txbEmailEditar = new System.Windows.Forms.TextBox();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblDescricaoApagar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibIcone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(285, 107);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(447, 196);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbSenhaCadastro);
            this.grbCadastro.Controls.Add(this.lblSenhaCadastro);
            this.grbCadastro.Controls.Add(this.txbEmailCadastro);
            this.grbCadastro.Controls.Add(this.lblEmailCadastro);
            this.grbCadastro.Controls.Add(this.lblNome);
            this.grbCadastro.Controls.Add(this.txbNomeCadastro);
            this.grbCadastro.Location = new System.Drawing.Point(29, 107);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(236, 164);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(108, 19);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(100, 20);
            this.txbNomeCadastro.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblEmailCadastro
            // 
            this.lblEmailCadastro.AutoSize = true;
            this.lblEmailCadastro.Location = new System.Drawing.Point(6, 53);
            this.lblEmailCadastro.Name = "lblEmailCadastro";
            this.lblEmailCadastro.Size = new System.Drawing.Size(32, 13);
            this.lblEmailCadastro.TabIndex = 2;
            this.lblEmailCadastro.Text = "Email";
            // 
            // txbEmailCadastro
            // 
            this.txbEmailCadastro.Location = new System.Drawing.Point(108, 53);
            this.txbEmailCadastro.Name = "txbEmailCadastro";
            this.txbEmailCadastro.Size = new System.Drawing.Size(100, 20);
            this.txbEmailCadastro.TabIndex = 3;
            this.txbEmailCadastro.TextChanged += new System.EventHandler(this.txbSenhaCadastro_TextChanged);
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.Location = new System.Drawing.Point(6, 83);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaCadastro.TabIndex = 4;
            this.lblSenhaCadastro.Text = "Senha";
            // 
            // txbSenhaCadastro
            // 
            this.txbSenhaCadastro.Location = new System.Drawing.Point(108, 83);
            this.txbSenhaCadastro.Name = "txbSenhaCadastro";
            this.txbSenhaCadastro.Size = new System.Drawing.Size(100, 20);
            this.txbSenhaCadastro.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(32, 109);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(154, 46);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.button1);
            this.grbEditar.Controls.Add(this.txbSenhaEditar);
            this.grbEditar.Controls.Add(this.lblSenhaEditar);
            this.grbEditar.Controls.Add(this.txbEmailEditar);
            this.grbEditar.Controls.Add(this.lblEmailEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(29, 296);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(236, 158);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            this.grbEditar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbSenhaEditar
            // 
            this.txbSenhaEditar.Location = new System.Drawing.Point(108, 83);
            this.txbSenhaEditar.Name = "txbSenhaEditar";
            this.txbSenhaEditar.Size = new System.Drawing.Size(100, 20);
            this.txbSenhaEditar.TabIndex = 5;
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(6, 80);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaEditar.TabIndex = 4;
            this.lblSenhaEditar.Text = "Senha";
            // 
            // txbEmailEditar
            // 
            this.txbEmailEditar.Location = new System.Drawing.Point(108, 53);
            this.txbEmailEditar.Name = "txbEmailEditar";
            this.txbEmailEditar.Size = new System.Drawing.Size(100, 20);
            this.txbEmailEditar.TabIndex = 3;
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Location = new System.Drawing.Point(6, 53);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(32, 13);
            this.lblEmailEditar.TabIndex = 2;
            this.lblEmailEditar.Text = "Email";
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(6, 22);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(82, 13);
            this.lblNomeEditar.TabIndex = 1;
            this.lblNomeEditar.Text = "Nome Completo";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(108, 19);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(100, 20);
            this.txbNomeEditar.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(22, 109);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(145, 36);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.lblDescricaoApagar);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(271, 349);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(507, 81);
            this.grbApagar.TabIndex = 3;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(425, 52);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoApagar
            // 
            this.lblDescricaoApagar.AutoSize = true;
            this.lblDescricaoApagar.Location = new System.Drawing.Point(21, 30);
            this.lblDescricaoApagar.Name = "lblDescricaoApagar";
            this.lblDescricaoApagar.Size = new System.Drawing.Size(168, 13);
            this.lblDescricaoApagar.TabIndex = 1;
            this.lblDescricaoApagar.Text = "Selecione um usuario para apagar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(136, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(245, 24);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Gerenciamento de Usuarios";
            // 
            // pibIcone
            // 
            this.pibIcone.Image = global::MiCommerce.Properties.Resources.baker;
            this.pibIcone.Location = new System.Drawing.Point(29, 13);
            this.pibIcone.Name = "pibIcone";
            this.pibIcone.Size = new System.Drawing.Size(100, 66);
            this.pibIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcone.TabIndex = 5;
            this.pibIcone.TabStop = false;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.pibIcone);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txbEmailCadastro;
        private System.Windows.Forms.Label lblEmailCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.TextBox txbSenhaCadastro;
        private System.Windows.Forms.Label lblSenhaCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbSenhaEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.TextBox txbEmailEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblDescricaoApagar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibIcone;
    }
}