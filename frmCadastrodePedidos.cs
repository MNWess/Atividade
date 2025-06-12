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
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cpf = txtCpfCliente.Text.Trim();
            if (!File.Exists("clientes.csv"))
            {
                MessageBox.Show("Arquivo de clientes não encontrado.");
                return;
            }

            var linhas = File.ReadAllLines("clientes.csv");
            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(';');
                if (partes.Length >= 2 && partes[1] == cpf)
                {
                    lblNomeCliente.Text = partes[0]; // Nome do cliente
                    return;
                }
            }

            lblNomeCliente.Text = "Cliente não encontrado";
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists("produtos.csv"))
            {
                var linhas = File.ReadAllLines("produtos.csv");
                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(';');
                    if (partes.Length >= 2)
                        cmbProduto.Items.Add($"{partes[0]} - R${partes[1]}");
                }
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedItem == null || numQuantidade.Value <= 0)
            {
                MessageBox.Show("Selecione um produto e uma quantidade válida.");
                return;
            }

            string item = cmbProduto.SelectedItem.ToString(); // Ex: "Camiseta - R$50"
            string nomeProduto = item.Split('-')[0].Trim();
            decimal preco = decimal.Parse(item.Split('R')[1]);
            int quantidade = (int)numQuantidade.Value;
            decimal total = preco * quantidade;

            dgvItensPedido.Rows.Add(nomeProduto, preco, quantidade, total);

        }

        private void lblTotalPedido_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvItensPedido.Rows)
            {
                total += Convert.ToDecimal(row.Cells[3].Value);
            }

            lblTotalPedido.Text = $"Total do Pedido: R$ {total:F2}";
        }

        private void btnGravarPedido_Click(object sender, EventArgs e)
        {
            if (dgvItensPedido.Rows.Count == 0)
            {
                MessageBox.Show("Adicione ao menos um produto.");
                return;
            }

            string id = Guid.NewGuid().ToString();
            string cpf = txtCpfCliente.Text;
            string nome = lblNomeCliente.Text;
            string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            List<string> itens = new List<string>();
            decimal totalPedido = 0;

            foreach (DataGridViewRow row in dgvItensPedido.Rows)
            {
                string nomeProd = row.Cells[0].Value.ToString();
                int qtd = Convert.ToInt32(row.Cells[2].Value);
                decimal total = Convert.ToDecimal(row.Cells[3].Value);
                totalPedido += total;

                itens.Add($"{nomeProd}|{qtd}|{total}");
            }

            string linha = $"{id};{cpf};{nome};{data};{string.Join(",", itens)};{totalPedido}";
            File.AppendAllText("pedidos.csv", linha + Environment.NewLine);

            MessageBox.Show("Pedido salvo com sucesso.");
        }

        private void btnExcluirPedido_Click(object sender, EventArgs e)
        {
            if (dgvItensPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido para excluir.");
                return;
            }

            string id = dgvItensPedido.SelectedRows[0].Cells[0].Value.ToString(); // Supondo que a 1ª coluna é o ID

            var linhas = File.ReadAllLines("pedidos.csv").ToList();
            linhas = linhas.Where(l => !l.StartsWith(id + ";")).ToList();
            File.WriteAllLines("pedidos.csv", linhas);

            MessageBox.Show("Pedido excluído com sucesso.");

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
