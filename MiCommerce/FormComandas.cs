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
    public partial class FormComandas : Form
    {
        Model.Usuario usario;
        public FormComandas(Model.Usuario usario)
        {
            InitializeComponent();
            this.usario = usario;
            Atualizardgv();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FormComandas_Load(object sender, EventArgs e)
        {

        }
        public void Atualizardgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvProdutos.DataSource = produto.listar();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            txbComandaInformacoes.Text = dgvProdutos.Rows[ls].Cells[0].Value.ToString ();
            txbprodutoinformacoes.Text = dgvProdutos.Rows[ls].Cells[0].Value.ToString();
        }
    }
}
