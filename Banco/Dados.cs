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
    public partial class Dados : Form
    {
        Usuario usuario;
        public Dados(Usuario user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void Dados_Load(object sender, EventArgs e)
        {

        }
    }
}
