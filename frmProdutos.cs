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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text;
            string preco = txtPreco.Text;
            string descricao = txtDescricao.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(preco))
            {
                MessageBox.Show("Nome e Preço são obrigatórios.");
                return;
            }

            string linha = $"{nome};{preco};{descricao}";
            File.AppendAllText("produtos.csv", linha + Environment.NewLine);

            MessageBox.Show("Produto cadastrado com sucesso!");

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Clear();
            dgvProdutos.Columns.Clear();

            dgvProdutos.Columns.Add("Nome", "Nome");
            dgvProdutos.Columns.Add("Preco", "Preço");
            dgvProdutos.Columns.Add("Descricao", "Descrição");

            if (File.Exists("produtos.csv"))
            {
                var linhas = File.ReadAllLines("produtos.csv");

                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(';');
                    if (partes.Length == 3)
                    {
                        dgvProdutos.Rows.Add(partes[0], partes[1], partes[2]);
                    }
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para atualizar.");
                return;
            }

            int index = dgvProdutos.SelectedRows[0].Index;
            var linhas = File.ReadAllLines("produtos.csv").ToList();

            string novaLinha = $"{txtNomeProduto.Text};{txtPreco.Text};{txtDescricao.Text}";
            linhas[index] = novaLinha;

            File.WriteAllLines("produtos.csv", linhas);
            MessageBox.Show("Produto atualizado!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            int index = dgvProdutos.SelectedRows[0].Index;
            var linhas = File.ReadAllLines("produtos.csv").ToList();
            linhas.RemoveAt(index);
            File.WriteAllLines("produtos.csv", linhas);

            MessageBox.Show("Produto excluído com sucesso.");
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNomeProduto.Text = dgvProdutos.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtPreco.Text = dgvProdutos.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtDescricao.Text = dgvProdutos.Rows[e.RowIndex].Cells[2].Value?.ToString();
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Clear();
            txtPreco.Clear();
            txtDescricao.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
