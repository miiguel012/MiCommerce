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
    public partial class MenuPrincipal : Form
    {
        //variaveis globais:
        Model.Usuario Usuario = new Model.Usuario();
        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            lbldescrição.Text = $"Ola {usuario.NomeCompleto},\nEscolha uma opçao abaixo:";
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            FormComandas formComandas = new FormComandas(Usuario);
            formComandas.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios(Usuario);
            formUsuarios.ShowDialog();//mostrar o form
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(Usuario);
            formProdutos.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FormCaixa formCaixa = new FormCaixa(Usuario);
            formCaixa.ShowDialog();
        }
    }
}
