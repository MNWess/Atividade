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
    public partial class frmCadastroUsuario : Form
    {
        private string usuarioLogado;
        public frmCadastroUsuario(string usuarioLogado)
        {
            InitializeComponent();
            this.usuarioLogado = usuarioLogado;
        }
        public frmCadastroUsuario()
        {
            InitializeComponent();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (usuarioLogado != "admin")
            {
                MessageBox.Show("Apenas o ADMIN pode cadastrar usuários.");
                return;
            }

            string usuario = txtUsuario.Text.Trim().ToLower();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha usuário e senha.");
                return;
            }

            var linhas = File.ReadAllLines("usuarios.csv").ToList();
            if (linhas.Any(l => l.Split(';')[0] == usuario))
            {
                MessageBox.Show("Usuário já existe.");
                return;
            }

            linhas.Add($"{usuario};{senha}");
            File.WriteAllLines("usuarios.csv", linhas);
            MessageBox.Show("Usuário cadastrado com sucesso.");
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Columns.Add("Usuario", "Usuário");

            var linhas = File.ReadAllLines("usuarios.csv");
            foreach (var linha in linhas)
            {
                string[] partes = linha.Split(';');
                dgvUsuarios.Rows.Add(partes[0]);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um usuário.");
                return;
            }

            string usuario = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
            if (usuario == "admin")
            {
                MessageBox.Show("Não é permitido excluir o ADMIN.");
                return;
            }

            var linhas = File.ReadAllLines("usuarios.csv").ToList();
            linhas = linhas.Where(l => !l.StartsWith(usuario + ";")).ToList();
            File.WriteAllLines("usuarios.csv", linhas);
            MessageBox.Show("Usuário excluído.");

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text.Trim();
            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show("Digite a nova senha.");
                return;
            }

            var linhas = File.ReadAllLines("usuarios.csv").ToList();
            for (int i = 0; i < linhas.Count; i++)
            {
                string[] partes = linhas[i].Split(';');
                if (partes[0] == usuarioLogado)
                {
                    linhas[i] = $"{usuarioLogado};{novaSenha}";
                    File.WriteAllLines("usuarios.csv", linhas);
                    MessageBox.Show("Senha alterada.");
                    return;
                }
            }

            MessageBox.Show("Usuário não encontrado.");
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            string path = "usuarios.csv";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "admin;123\n");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
