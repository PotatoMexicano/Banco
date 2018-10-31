namespace Banco
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosPessoaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saqueToolStripMenuItem,
            this.depositoToolStripMenuItem,
            this.extratoToolStripMenuItem,
            this.dadosPessoaisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saqueToolStripMenuItem
            // 
            this.saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            this.saqueToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.saqueToolStripMenuItem.Text = "Saque";
            this.saqueToolStripMenuItem.Click += new System.EventHandler(this.saqueToolStripMenuItem_Click);
            // 
            // depositoToolStripMenuItem
            // 
            this.depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            this.depositoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.depositoToolStripMenuItem.Text = "Deposito";
            this.depositoToolStripMenuItem.Click += new System.EventHandler(this.depositoToolStripMenuItem_Click);
            // 
            // extratoToolStripMenuItem
            // 
            this.extratoToolStripMenuItem.Name = "extratoToolStripMenuItem";
            this.extratoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.extratoToolStripMenuItem.Text = "Extrato";
            this.extratoToolStripMenuItem.Click += new System.EventHandler(this.extratoToolStripMenuItem_Click);
            // 
            // dadosPessoaisToolStripMenuItem
            // 
            this.dadosPessoaisToolStripMenuItem.Name = "dadosPessoaisToolStripMenuItem";
            this.dadosPessoaisToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.dadosPessoaisToolStripMenuItem.Text = "Dados pessoais";
            this.dadosPessoaisToolStripMenuItem.Click += new System.EventHandler(this.dadosPessoaisToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosPessoaisToolStripMenuItem;
    }
}