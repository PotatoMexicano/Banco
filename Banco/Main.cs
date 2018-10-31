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
    public partial class Main : Form
    {
        Usuario usuario;
        Conta conta_corrente;
        Conta conta_poupança;
        double total;
        public Main(Usuario user)
        {
            usuario = user;
            InitializeComponent();
            Atualiza_saldo_geral();
            
        }
        public void Atualiza_saldo_geral()
        {
            conta_corrente = Control.Extrato(usuario.Id);
            conta_poupança = Control.Extrato_Poup(usuario.Id);
            total = conta_corrente.Saldo + conta_poupança.Saldo;
            label_hi.Text = "Bem-Vindo " + usuario.Nome + " " + usuario.Sobrenome;
            label_saldo.Text = "R$ " + total;
            label3.Text = Convert.ToString(conta_corrente.Ultima_alteracao.ToString("d/M/yyyy"));
        }

        private void DadosPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Dados>().Count() > 0)
            {
                MessageBox.Show("Formulario já aberto");
            }
            else
            {
                Dados dados = new Dados(usuario);
                dados.ShowDialog();
            }
            
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();

        }

        private void SaqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saque saque = new Saque(usuario);
            saque.ShowDialog();
        }

        private void CorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extrato extrato = new Extrato(usuario, 0);
            extrato.ShowDialog();
        }

        private void PoupançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extrato extrato = new Extrato(usuario, 1);
            extrato.ShowDialog();
        }

        private void CorrenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito(usuario, 0);
            deposito.ShowDialog();
        }

        private void PoupançaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito(usuario, 1);
            deposito.ShowDialog();
        }
    }
}
