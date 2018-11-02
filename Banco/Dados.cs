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

            switch (usuario.Tipo)
            {
                case 0:
                    label_tipo.Text = "Conta Corrente";
                    break;
                case 1:
                    label_tipo.Text = "Conta Poupança";
                    break;
                case 2:
                    label_tipo.Text = "Conta Corrente/Poupança";
                    break;
            }

            label_senha.Text = usuario.Senha.ToString() + " (Apenas didatico)";

            label_nome.Text = usuario.Nome.ToString();

            label_sobrenome.Text = usuario.Sobrenome.ToString();

           
            char[] cpf = usuario.Cpf.ToString().ToCharArray();
            int size = cpf.Count();
            string mudado = usuario.Cpf.ToString().Remove(usuario.Cpf.ToString().Length - 1);
            label_cpf.Text = mudado + "-" + cpf[size-1];



            label_rg.Text = usuario.Rg.ToString();

            
            if (usuario.Sexo.ToString() =="M")
            {
                label_sexo.Text = "Masculino";
            }
            else
            {
                label_sexo.Text = "Feminino";
            }

            label_idade.Text = usuario.Idade.ToString();   



        }
    }
}
