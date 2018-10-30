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
            if (combo_tipo.Text == "Poupança") { tipo = 1; } else { tipo = 0; }
            if (combo_sexo.Text == "Masculino") { sexo = 'M'; } else { sexo = 'F'; }
            
            Control.cadastrar(txt_nome.Text, txt_sobrenome.Text, txt_cpf.Text, txt_rg.Text, Convert.ToInt32(txt_agencia.Text), txt_senha.Text, tipo, sexo, Convert.ToInt32(txt_idade.Text));
        }
    }
}
