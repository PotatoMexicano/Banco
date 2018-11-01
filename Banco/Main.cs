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
            if (usuario.Tipo == 0)
            {
                conta_corrente = Control.Extrato(usuario.Id);
                total = conta_corrente.Saldo;
            }
            else if(usuario.Tipo == 1)
            {
                conta_poupança = Control.Extrato_Poup(usuario.Id);
                total = conta_poupança.Saldo;
            }
            else
            {
                conta_corrente = Control.Extrato(usuario.Id);
                conta_poupança = Control.Extrato_Poup(usuario.Id);
                total = conta_corrente.Saldo + conta_poupança.Saldo;
            }

                
                label_hi.Text = "Bem-Vindo " + usuario.Nome + " " + usuario.Sobrenome;
                label_saldo.Text = "R$ " + total;
                label3.Text = Convert.ToString(usuario.Ultimo_acesso.ToString("d/M/yyyy"));
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (usuario.Tipo == 0)
            {
                poupançaToolStripMenuItem.Visible = false;
                poupançaToolStripMenuItem1.Visible = false;
                poupançaToolStripMenuItem2.Visible = false;
            }
            else if (usuario.Tipo == 1)
            {
                correnteToolStripMenuItem.Visible = false;
                correnteToolStripMenuItem1.Visible = false;
                correnteToolStripMenuItem2.Visible = false;
                
            }
        }

        private void correnteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
                Saque saque = new Saque(usuario, 0);
                saque.ShowDialog();
        }

        private void poupançaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
                Saque saque = new Saque(usuario, 1);
                saque.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                Close();
                
            }
        }

        private void desligarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja desligar ?", "Desligar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
