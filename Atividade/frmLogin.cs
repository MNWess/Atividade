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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrarr_Click(object sender, EventArgs e)
        {
            string usuario = txtLogin.Text.Trim();
            string senha = txtSenha.Text;

            bool credenciaisValidas = false;

            // Verifica se é o admin
            if (usuario.Equals("ADMIN", StringComparison.OrdinalIgnoreCase) && senha == "123")
            {
                credenciaisValidas = true;
            }
            else
            {
                // Verifica as credenciais no CSV
                string caminhoArquivo = "usuarios.csv"; // certifique-se que o arquivo está no diretório correto

                if (File.Exists(caminhoArquivo))
                {
                    var linhas = File.ReadAllLines(caminhoArquivo);

                    foreach (string linha in linhas)
                    {
                        string[] partes = linha.Split(',');
                        if (partes.Length == 2)
                        {
                            string usuarioArquivo = partes[0].Trim();
                            string senhaArquivo = partes[1].Trim();

                            if (usuario.Equals(usuarioArquivo, StringComparison.OrdinalIgnoreCase) && senha == senhaArquivo)
                            {
                                credenciaisValidas = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo de usuários não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (credenciaisValidas)
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir formulário principal
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                this.Hide(); // esconde o formulário de login
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
