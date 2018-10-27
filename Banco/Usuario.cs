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
        private string nome;
        private string sobrenome;
        private string cpf;
        private string rg;
        private int conta;
        private int agencia; 
        private string senha;
        private int tipo;
        private char sexo;
        private int idade;

        public Usuario(int id, string nome, string sobrenome, string cpf, string rg, int conta, int agencia, string senha, int tipo, char sexo, int idade)
        {
            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.rg = rg;
            this.conta = conta;
            this.agencia = agencia;
            this.senha = senha;
            this.tipo = tipo;
            this.sexo = sexo;
            this.idade = idade;
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
        public char Sexo { get => sexo; set => sexo = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}
