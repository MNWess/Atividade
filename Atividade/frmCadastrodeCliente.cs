using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Atividade
{
    public partial class frmCadastrodeCliente : Form
    {
        private async void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            string cep = txtCep.Text.Trim().Replace("-", "").Replace(".", "");
            if (cep.Length != 8)
            {
                MessageBox.Show("CEP inválido.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    var resposta = await client.GetAsync(url);
                    if (resposta.IsSuccessStatusCode)
                    {
                        string json = await resposta.Content.ReadAsStringAsync();
                        dynamic endereco = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                        if (endereco.erro != null)
                        {
                            MessageBox.Show("CEP não encontrado.");
                            return;
                        }

                        txtLogradouro.Text = endereco.logradouro;
                        txtBairro.Text = endereco.bairro;
                        txtCidade.Text = endereco.localidade;
                        txtEstado.Text = endereco.uf;
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao consultar o CEP.");
                }
            }
        }
        public frmCadastrodeCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add("Nome", "Nome");
            dgvClientes.Columns.Add("CPF", "CPF");
            dgvClientes.Columns.Add("Email", "Email");
            dgvClientes.Columns.Add("Telefone", "Telefone");
            dgvClientes.Columns.Add("Whatsapp", "WhatsApp");

            if (File.Exists("clientes.csv"))
            {
                var linhas = File.ReadAllLines("clientes.csv");
                foreach (var linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    dgvClientes.Rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4]);
                }
            }

            int row = e.RowIndex;
            if (row >= 0)
            {
                string[] campos = File.ReadAllLines("clientes.csv")[row].Split(';');

                txtNome.Text = campos[0];
                txtCpf.Text = campos[1];
                txtEmail.Text = campos[2];
                txtTelefone.Text = campos[3];
                txtWhatsapp.Text = campos[4];
                txtCep.Text = campos[5];
                txtLogradouro.Text = campos[6];
                txtNumero.Text = campos[7];
                txtBairro.Text = campos[8];
                txtCidade.Text = campos[9];
                txtEstado.Text = campos[10];
            }
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string linha = $"{txtNome.Text};{txtCpf.Text};{txtEmail.Text};{txtTelefone.Text};{txtWhatsapp.Text};{txtCep.Text};{txtLogradouro.Text};{txtNumero.Text};{txtBairro.Text};{txtCidade.Text};{txtEstado.Text}";

            File.AppendAllText("clientes.csv", linha + Environment.NewLine);
            MessageBox.Show("Cliente salvo com sucesso!");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
