namespace Atividade
{
    partial class frmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblNomeCliente = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotalPedido = new Label();
            label6 = new Label();
            txtCpfCliente = new TextBox();
            btnBuscarCliente = new Button();
            cmbProduto = new ComboBox();
            numQuantidade = new NumericUpDown();
            btnAdicionarProduto = new Button();
            dgvItensPedido = new DataGridView();
            btnGravarPedido = new Button();
            btnExcluirPedido = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 55);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "CPF";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(322, 56);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(42, 15);
            lblNomeCliente.TabIndex = 1;
            lblNomeCliente.Text = "NOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 92);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "PRODUTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 92);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "QUANTIDADE";
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Location = new Point(114, 217);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(42, 15);
            lblTotalPedido.TabIndex = 4;
            lblTotalPedido.Text = "TOTAL ";
            lblTotalPedido.Click += lblTotalPedido_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 217);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 5;
            label6.Text = "R$";
            // 
            // txtCpfCliente
            // 
            txtCpfCliente.Location = new Point(148, 52);
            txtCpfCliente.Name = "txtCpfCliente";
            txtCpfCliente.Size = new Size(100, 23);
            txtCpfCliente.TabIndex = 6;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(254, 52);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(62, 23);
            btnBuscarCliente.TabIndex = 7;
            btnBuscarCliente.Text = "BUSCAR";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(180, 89);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(121, 23);
            cmbProduto.TabIndex = 8;
            cmbProduto.SelectedIndexChanged += cmbProduto_SelectedIndexChanged;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(393, 90);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(47, 23);
            numQuantidade.TabIndex = 9;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(446, 90);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(79, 23);
            btnAdicionarProduto.TabIndex = 10;
            btnAdicionarProduto.Text = "ADICIONAR";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Location = new Point(114, 119);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.Size = new Size(484, 85);
            dgvItensPedido.TabIndex = 11;
            // 
            // btnGravarPedido
            // 
            btnGravarPedido.Location = new Point(114, 254);
            btnGravarPedido.Name = "btnGravarPedido";
            btnGravarPedido.Size = new Size(111, 23);
            btnGravarPedido.TabIndex = 12;
            btnGravarPedido.Text = "GRAVAR PEDIDO";
            btnGravarPedido.UseVisualStyleBackColor = true;
            btnGravarPedido.Click += btnGravarPedido_Click;
            // 
            // btnExcluirPedido
            // 
            btnExcluirPedido.Location = new Point(114, 283);
            btnExcluirPedido.Name = "btnExcluirPedido";
            btnExcluirPedido.Size = new Size(111, 23);
            btnExcluirPedido.TabIndex = 13;
            btnExcluirPedido.Text = "EXCLUIR PEDIDO";
            btnExcluirPedido.UseVisualStyleBackColor = true;
            btnExcluirPedido.Click += btnExcluirPedido_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(677, 415);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(111, 23);
            btnVoltar.TabIndex = 14;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnExcluirPedido);
            Controls.Add(btnGravarPedido);
            Controls.Add(dgvItensPedido);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(numQuantidade);
            Controls.Add(cmbProduto);
            Controls.Add(btnBuscarCliente);
            Controls.Add(txtCpfCliente);
            Controls.Add(label6);
            Controls.Add(lblTotalPedido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNomeCliente);
            Controls.Add(label1);
            Name = "frmPedidos";
            Text = "Formulário de Cadastro de Pedidos";
            Load += frmPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNomeCliente;
        private Label label3;
        private Label label4;
        private Label lblTotalPedido;
        private Label label6;
        private TextBox txtCpfCliente;
        private Button btnBuscarCliente;
        private ComboBox cmbProduto;
        private NumericUpDown numQuantidade;
        private Button btnAdicionarProduto;
        private DataGridView dgvItensPedido;
        private Button btnGravarPedido;
        private Button btnExcluirPedido;
        private Button btnVoltar;
    }
}