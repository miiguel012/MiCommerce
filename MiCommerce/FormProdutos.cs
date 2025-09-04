using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCommerce
{
    public partial class FormProdutos : Form
    {
     Model.Usuario usuario;
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        public void ListarCategoriascmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // Tabela p/ receber o resultado do Select:
            DataTable tabela = categoria.listar();

            foreach (DataRow dr in tabela.Rows)
            {
                // 1 - Salgados
                // 2 - Refrigerantes
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                
            }
        }




        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
