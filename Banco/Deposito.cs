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
    public partial class Deposito : Form
    {
        Usuario usuario;
        Conta conta;
        public Deposito(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            atualiza_label_saldo();
            
        }
        public void atualiza_label_saldo() {
            conta = Control.Extrato(usuario.Id);
            label_money.Text = "R$ "+Convert.ToString(conta.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double deposito = Convert.ToDouble(tb_deposito.Text);
            if (deposito > 1000)
            {
                MessageBox.Show("Desculpe, depositos acima de R$ 1000,00 não são permitidos.");
            }
            else
            {
                if (!(deposito < 0))
                {
                    if (MessageBox.Show("Confirma ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Control.Depositar(deposito, conta.Id_user);
                        atualiza_label_saldo();
                    }
                    else
                    {
                        tb_deposito.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Não digite valores negativos.");
                }

            }     
            
        }
    }
}
