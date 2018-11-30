namespace Banco
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox_Conta = new System.Windows.Forms.TextBox();
            this.lb_agencia = new System.Windows.Forms.Label();
            this.lb_conta = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_agencia = new System.Windows.Forms.ComboBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Account = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Conta
            // 
            this.textBox_Conta.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Conta.Location = new System.Drawing.Point(336, 179);
            this.textBox_Conta.MaxLength = 7;
            this.textBox_Conta.Name = "textBox_Conta";
            this.textBox_Conta.Size = new System.Drawing.Size(121, 23);
            this.textBox_Conta.TabIndex = 1;
            // 
            // lb_agencia
            // 
            this.lb_agencia.AutoSize = true;
            this.lb_agencia.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_agencia.Location = new System.Drawing.Point(258, 146);
            this.lb_agencia.Name = "lb_agencia";
            this.lb_agencia.Size = new System.Drawing.Size(72, 18);
            this.lb_agencia.TabIndex = 2;
            this.lb_agencia.Text = "Agencia:";
            // 
            // lb_conta
            // 
            this.lb_conta.AutoSize = true;
            this.lb_conta.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_conta.Location = new System.Drawing.Point(258, 180);
            this.lb_conta.Name = "lb_conta";
            this.lb_conta.Size = new System.Drawing.Size(56, 18);
            this.lb_conta.TabIndex = 3;
            this.lb_conta.Text = "Conta:";
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(277, 259);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(160, 34);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Entrar";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBox_agencia);
            this.panel1.Controls.Add(this.textBox_senha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Account);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.lb_conta);
            this.panel1.Controls.Add(this.textBox_Conta);
            this.panel1.Controls.Add(this.lb_agencia);
            this.panel1.Controls.Add(this.pb_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 337);
            this.panel1.TabIndex = 5;
            // 
            // txtBox_agencia
            // 
            this.txtBox_agencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBox_agencia.FormattingEnabled = true;
            this.txtBox_agencia.Items.AddRange(new object[] {
            "1001",
            "1002",
            "1003",
            "1004",
            "1005"});
            this.txtBox_agencia.Location = new System.Drawing.Point(336, 146);
            this.txtBox_agencia.Name = "txtBox_agencia";
            this.txtBox_agencia.Size = new System.Drawing.Size(121, 21);
            this.txtBox_agencia.TabIndex = 8;
            // 
            // textBox_senha
            // 
            this.textBox_senha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_senha.Location = new System.Drawing.Point(336, 215);
            this.textBox_senha.MaxLength = 4;
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = ' ';
            this.textBox_senha.Size = new System.Drawing.Size(121, 23);
            this.textBox_senha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Senha:";
            // 
            // btn_Account
            // 
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.Location = new System.Drawing.Point(646, 12);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(124, 33);
            this.btn_Account.TabIndex = 4;
            this.btn_Account.Text = "Abrir uma conta";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(243, 4);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(249, 135);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 5;
            this.pb_Logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 337);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(798, 376);
            this.MinimumSize = new System.Drawing.Size(798, 376);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Conta;
        private System.Windows.Forms.Label lb_agencia;
        private System.Windows.Forms.Label lb_conta;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.ComboBox txtBox_agencia;
        private System.Windows.Forms.PictureBox pb_Logo;
    }
}

