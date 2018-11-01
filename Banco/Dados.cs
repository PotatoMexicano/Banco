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
            label_conta.Text = usuario.Conta.ToString();
            label_agencia.Text = usuario.Agencia.ToString();
            label_tipo.Text = usuario.Tipo.ToString();
            label_senha.Text = usuario.Senha.ToString();
            label_nome.Text = usuario.Nome.ToString();
            label_sobrenome.Text = usuario.Sobrenome.ToString();
            label_cpf.Text = usuario.Cpf.ToString();
            label_rg.Text = usuario.Rg.ToString();
            label_sexo.Text = usuario.Sexo.ToString();
            label_idade.Text = usuario.Idade.ToString();   



        }
    }
}
