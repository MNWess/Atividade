using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{

    public partial class frmPrincipal : Form
    {
        private string usuarioLogado;

        public frmPrincipal()
        {
            InitializeComponent();
            usuarioLogado = usuarioLogado;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProdutos produtosForm = new frmProdutos();
            produtosForm.ShowDialog();
            Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos produtosForm = new frmPedidos();
            produtosForm.ShowDialog();
            Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario(usuarioLogado);
            frmCadastroUsuario.ShowDialog();
            Hide();

        }
    }
}
