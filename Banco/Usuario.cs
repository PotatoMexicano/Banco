using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Usuario
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
        private DateTime ultimo_acesso;


        public Usuario(int id, string nome, string sobrenome, string cpf, string rg, int conta, int agencia, string senha, int tipo, char sexo, int idade, DateTime ultimo_acesso)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Conta = conta;
            this.Agencia = agencia;
            this.Senha = senha;
            this.tipo = tipo;
            this.Sexo = sexo;
            this.Idade = idade;
            this.Ultimo_acesso = ultimo_acesso;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public int Conta { get => conta; set => conta = value; }
        public int Agencia { get => agencia; set => agencia = value; }
        public string Senha { get => senha; set => senha = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public int Idade { get => idade; set => idade = value; }
        public DateTime Ultimo_acesso { get => ultimo_acesso; set => ultimo_acesso = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
