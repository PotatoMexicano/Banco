﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Banco
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!(txtBox_agencia.Text.Equals("") || textBox_Conta.Text.Equals("") || textBox_senha.Text.Equals("")))
            {

                Usuario usuario = Control.Login(Convert.ToInt32(txtBox_agencia.Text), Convert.ToInt32(textBox_Conta.Text), textBox_senha.Text);
                if (usuario != null)
                {
                    Control.Atualiza_Data_Login(usuario.Id);
                    Main menu = new Main(usuario);
                    this.Hide();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
            else
            {
                MessageBox.Show("Não");
            }
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            NovaConta novaConta = new NovaConta();
            this.Hide();
            novaConta.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
