namespace Atividade
{
    partial class frmCadastroUsuario
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
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtNovaSenha = new TextBox();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnAlterarSenha = new Button();
            dgvUsuarios = new DataGridView();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "USÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "SENHA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 88);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "NOVA SENHA";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(76, 18);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(76, 47);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 4;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(108, 85);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(100, 23);
            txtNovaSenha.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(22, 138);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(81, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(109, 138);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(62, 23);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.Location = new Point(177, 138);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(104, 23);
            btnAlterarSenha.TabIndex = 8;
            btnAlterarSenha.Text = "LATERAR SENHA";
            btnAlterarSenha.UseVisualStyleBackColor = true;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(22, 185);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(259, 150);
            dgvUsuarios.TabIndex = 9;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(206, 341);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 24);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 391);
            Controls.Add(btnVoltar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnAlterarSenha);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCadastroUsuario";
            Text = "Formulário de Cadastro de Usuários";
            Load += frmCadastroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtNovaSenha;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Button btnAlterarSenha;
        private DataGridView dgvUsuarios;
        private Button btnVoltar;
    }
}