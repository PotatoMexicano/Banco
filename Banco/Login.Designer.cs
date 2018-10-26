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
            this.txtBox_agencia = new System.Windows.Forms.TextBox();
            this.textBox_Conta = new System.Windows.Forms.TextBox();
            this.lb_agencia = new System.Windows.Forms.Label();
            this.lb_conta = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Account = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_agencia
            // 
            this.txtBox_agencia.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_agencia.Location = new System.Drawing.Point(336, 17);
            this.txtBox_agencia.MaxLength = 4;
            this.txtBox_agencia.Name = "txtBox_agencia";
            this.txtBox_agencia.Size = new System.Drawing.Size(75, 23);
            this.txtBox_agencia.TabIndex = 0;
            // 
            // textBox_Conta
            // 
            this.textBox_Conta.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Conta.Location = new System.Drawing.Point(479, 16);
            this.textBox_Conta.MaxLength = 7;
            this.textBox_Conta.Name = "textBox_Conta";
            this.textBox_Conta.Size = new System.Drawing.Size(76, 23);
            this.textBox_Conta.TabIndex = 1;
            // 
            // lb_agencia
            // 
            this.lb_agencia.AutoSize = true;
            this.lb_agencia.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_agencia.Location = new System.Drawing.Point(258, 17);
            this.lb_agencia.Name = "lb_agencia";
            this.lb_agencia.Size = new System.Drawing.Size(72, 18);
            this.lb_agencia.TabIndex = 2;
            this.lb_agencia.Text = "Agencia:";
            // 
            // lb_conta
            // 
            this.lb_conta.AutoSize = true;
            this.lb_conta.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_conta.Location = new System.Drawing.Point(417, 18);
            this.lb_conta.Name = "lb_conta";
            this.lb_conta.Size = new System.Drawing.Size(56, 18);
            this.lb_conta.TabIndex = 3;
            this.lb_conta.Text = "Conta:";
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(597, 10);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(160, 34);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Entrar";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Account);
            this.panel1.Controls.Add(this.pb_Logo);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.txtBox_agencia);
            this.panel1.Controls.Add(this.lb_conta);
            this.panel1.Controls.Add(this.textBox_Conta);
            this.panel1.Controls.Add(this.lb_agencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 337);
            this.panel1.TabIndex = 5;
            // 
            // btn_Account
            // 
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.Location = new System.Drawing.Point(3, 134);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(203, 59);
            this.btn_Account.TabIndex = 4;
            this.btn_Account.Text = "Abrir uma conta";
            this.btn_Account.UseVisualStyleBackColor = true;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = global::Banco.Properties.Resources.HSBC;
            this.pb_Logo.Location = new System.Drawing.Point(3, 3);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(249, 98);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 5;
            this.pb_Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Senha:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(336, 53);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = ' ';
            this.textBox1.Size = new System.Drawing.Size(75, 23);
            this.textBox1.TabIndex = 2;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_agencia;
        private System.Windows.Forms.TextBox textBox_Conta;
        private System.Windows.Forms.Label lb_agencia;
        private System.Windows.Forms.Label lb_conta;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

