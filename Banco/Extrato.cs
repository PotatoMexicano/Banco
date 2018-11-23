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
            else if(i == 1)
            {
                Conta conta = Control.Extrato_Poup(usuario.Id);
                label_money.Text = "R$ " + Convert.ToString(conta.Saldo);
            }

            dataGridView1.DataSource = Control.Historico_Corrente(usuario.Id, usuario.Conta);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Tipo";
            dataGridView1.Columns[4].HeaderText = "Valor";
            dataGridView1.Columns[5].HeaderText = "Data";

        }

        private void Extrato_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Extrato_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
