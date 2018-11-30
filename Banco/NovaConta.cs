using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class NovaConta : Form
    {
        public NovaConta()
        {
            InitializeComponent();
        }

        private void NovaConta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo;
            char sexo;
            if (combo_tipo.Text == "Corrente") { tipo = 0; }else if (combo_tipo.Text == "Ambos") { tipo = 2; } else { tipo = 1; }
            if (combo_sexo.Text == "Masculino") { sexo = 'M'; } else { sexo = 'F'; }

            Random rnd = new Random();
            int conta = rnd.Next(1111111, 9999999);

            if (!(txt_nome.Text.Equals("") || txt_sobrenome.Text.Equals("") || txt_cpf.Text.Equals("") || txt_rg.Text.Equals("")|| txt_agencia.Text.Equals("") || txt_senha.Text.Equals("") || combo_tipo.Text.Equals("") || combo_sexo.Text.Equals("") || txt_idade.Text.Equals("")))
            {
                Control.Cadastrar(txt_nome.Text, txt_sobrenome.Text, txt_cpf.Text, txt_rg.Text, Convert.ToInt32(txt_agencia.Text), txt_senha.Text, tipo, sexo, Convert.ToInt32(txt_idade.Text), conta);
                Usuario usuario = Control.Login(Convert.ToInt32(txt_agencia.Text), conta, txt_senha.Text);
                Control.Criar_Conta(tipo, usuario.Id);
                MessageBox.Show("Sua conta é: " + conta);

                Login login = new Login();
                this.Hide();
                login.ShowDialog();
            }
            else{
                MessageBox.Show("Não tente me enganar");
            }
           
        }
    }
}
