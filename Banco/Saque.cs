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
    public partial class Saque : Form
    {
        Usuario usuario;
        Conta conta;
        int tipo;
        public Saque(Usuario usuario, int tipo)
        {
            this.usuario = usuario;
            this.tipo = tipo;
            InitializeComponent();
            atualiza_label_saldo();
        }
        public void atualiza_label_saldo()
        {
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
            double valor = Convert.ToDouble(tb_saque.Text);
            

            if (!(valor < 0))
            {
                if (!(valor > conta.Saldo))
                {
                    if (MessageBox.Show("Confirma ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        Control.Sacar(usuario.Id, valor, tipo, usuario.Conta);
                        atualiza_label_saldo();
                    }
                    else
                    {
                        tb_saque.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Não é possivel sacar esta quantia.");
                }
            }
            else{
                MessageBox.Show("Não digite valores negativos.");
            }
        }
    }
}
