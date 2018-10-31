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
    public partial class Extrato : Form
    {
        Usuario usuario;
        public Extrato(Usuario user, int i)
        {
            this.usuario = user;
            InitializeComponent();
            if (i == 0) {
                Conta conta = Control.Extrato(usuario.Id);
                label_money.Text = "R$ " + Convert.ToString(conta.Saldo);
            }
            else
            {
                Conta conta = Control.Extrato_Poup(usuario.Id);
                label_money.Text = "R$ " + Convert.ToString(conta.Saldo);
            }
        }

        private void Extrato_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Extrato_Load(object sender, EventArgs e)
        {
        }
    }
}
