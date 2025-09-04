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
    public partial class FormCaixa : Form
    {
        Model.Usuario Usuario;
        public FormCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }
    }
}
