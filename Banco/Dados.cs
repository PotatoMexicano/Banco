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
    public partial class Dados : Form
    {
        Usuario usuario;
        public Dados(Usuario user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void Dados_Load(object sender, EventArgs e)
        {

            if (usuario.Id == 3)
            {
                button1.Visible = false;
            }
            label_conta.Text = usuario.Conta.ToString();

            label_agencia.Text = usuario.Agencia.ToString();

            switch (usuario.Tipo)
            {
                case 0:
                    label_tipo.Text = "Conta Corrente";
                    break;
                case 1:
                    label_tipo.Text = "Conta Poupança";
                    break;
                case 2:
                    label_tipo.Text = "Conta Corrente/Poupança";
                    break;
            }

            label_senha.Text = usuario.Senha.ToString() + " (Apenas didatico)";

            label_nome.Text = usuario.Nome.ToString();

            label_sobrenome.Text = usuario.Sobrenome.ToString();

           
            char[] cpf = usuario.Cpf.ToString().ToCharArray();
            int size = cpf.Count();
            string mudado = usuario.Cpf.ToString().Remove(usuario.Cpf.ToString().Length - 1);
            label_cpf.Text = mudado + "-" + cpf[size-1];



            label_rg.Text = usuario.Rg.ToString();

            
            if (usuario.Sexo.ToString() =="M")
            {
                label_sexo.Text = "Masculino";
            }
            else
            {
                label_sexo.Text = "Feminino";
            }

            label_idade.Text = usuario.Idade.ToString();   



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Excluir ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Conta conta_c, conta_p;
                
                bool empty = true;

                switch (usuario.Tipo)
                {
                    case 0:
                        conta_c = Control.Extrato(usuario.Id);
                        if (conta_c.Saldo > 0)
                        {
                            empty = false;
                        }
                        break;
                    case 1:
                        conta_p = Control.Extrato_Poup(usuario.Id);
                        if (conta_p.Saldo > 0)
                        {
                            empty = false;
                        }
                        break;
                            case 2:
                        conta_c = Control.Extrato(usuario.Id);
                        conta_p = Control.Extrato_Poup(usuario.Id);
                        if (conta_c.Saldo > 0 && conta_p.Saldo > 0)
                        {
                            empty = false;
                        }
                        break;
                }
                if (empty)
                {
                    Control.Remover_Conta(usuario.Id, usuario.Senha, usuario.Cpf, usuario.Tipo);
                    Close();
                    
                }
                else
                {
                    MessageBox.Show("A conta ainda possui dinheiro");
                }

                
            }
            else
            {

            }
        }
    }
}
