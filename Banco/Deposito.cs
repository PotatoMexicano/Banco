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
        int tipo;
        public Deposito(Usuario usuario, int i)
        {
            this.usuario = usuario;
            InitializeComponent();
            if (i == 0)
            {
                tipo = 0;
            }
            else
            {
                tipo = 1;
            }
            atualiza_label_saldo();
            
            
        }
        public void atualiza_label_saldo() {
            if (tipo == 0) {
                conta = Control.Extrato(usuario.Id);
                label_money.Text = "R$ " + Convert.ToString(conta.Saldo);
            }
            else
            {
                conta = Control.Extrato_Poup(usuario.Id);
                label_money.Text = "R$ " + Convert.ToString(conta.Saldo);
            }
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
                        if (tipo == 0) {
                            Control.Depositar(deposito, conta.Id_user, 0);
                            atualiza_label_saldo();
                        }
                        else
                        {
                            Control.Depositar(deposito, conta.Id_user, 1);
                            atualiza_label_saldo();

                        }
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

        private void Deposito_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
