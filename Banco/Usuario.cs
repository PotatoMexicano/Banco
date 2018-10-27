using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Usuario
    {
        private int id;
        private int conta;
        private int agencia;
        private string nome;
        private string sobrenome;
        private string cpf;
        private string rg;
        private string senha;
        private int tipo;

        public Usuario(int id, string nome, string sobrenome, string cpf, string rg, int conta, int agencia, string senha, int tipo)
        {
            this.Id = id;
            this.Conta = conta;
            this.Agencia = agencia;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Senha = senha;
            this.Tipo = tipo;
        }

        public int Id { get => id; set => id = value; }
        public int Conta { get => conta; set => conta = value; }
        public int Agencia { get => agencia; set => agencia = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
