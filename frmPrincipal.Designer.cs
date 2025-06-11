namespace Atividade
{
    partial class frmPrincipal
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
            btnClientes = new Button();
            btnProdutos = new Button();
            btnPedidos = new Button();
            btnUser = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(70, 48);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(132, 23);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Cadastro de Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += button1_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(70, 77);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(132, 23);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Cadastro de Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += button2_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(70, 106);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(132, 23);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Cadastro de Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(70, 135);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(132, 23);
            btnUser.TabIndex = 3;
            btnUser.Text = "Cadastro de Usuários";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 224);
            Controls.Add(btnUser);
            Controls.Add(btnPedidos);
            Controls.Add(btnProdutos);
            Controls.Add(btnClientes);
            Name = "frmPrincipal";
            Text = "Formulário Principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProdutos;
        private Button btnPedidos;
        private Button btnUser;
    }
}