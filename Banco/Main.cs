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
        public Main(Usuario user)
        {
            usuario = user;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void dadosPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
