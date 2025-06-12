namespace Atividade
{
    partial class frmLogin
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
            btnSair = new Button();
            label1 = new Label();
            txtLogin = new TextBox();
            label2 = new Label();
            txtSenha = new TextBox();
            btnEntrarr = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(373, 248);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 0;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 164);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(363, 161);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 193);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "SENHA";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(363, 190);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 4;
            // 
            // btnEntrarr
            // 
            btnEntrarr.Location = new Point(373, 219);
            btnEntrarr.Name = "btnEntrarr";
            btnEntrarr.Size = new Size(75, 23);
            btnEntrarr.TabIndex = 5;
            btnEntrarr.Text = "ENTRAR ";
            btnEntrarr.UseVisualStyleBackColor = true;
            btnEntrarr.Click += btnEntrarr_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrarr);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            Controls.Add(btnSair);
            Name = "frmLogin";
            Text = "Formulário de Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Label label1;
        private TextBox txtLogin;
        private Label label2;
        private TextBox txtSenha;
        private Button btnEntrarr;
    }
}