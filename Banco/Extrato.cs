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
        public Extrato(Usuario user)
        {
            this.usuario = user;
            InitializeComponent();
            Conta conta = Control.extrato(usuario.Id);
            label_money.Text = "R$ "+Convert.ToString(conta.Saldo);
        }

        private void Extrato_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
