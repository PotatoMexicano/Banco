using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        private int id;
        private int id_user;
        private double saldo;
        private DateTime ultima_alteracao;

        public Conta(int id, int id_user, double saldo, DateTime ultima_alteracao)
        {
            this.Id = id;
            this.Id_user = id_user;
            this.Saldo = saldo;
            this.Ultima_alteracao = ultima_alteracao;
        }

        public int Id { get => id; set => id = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public DateTime Ultima_alteracao { get => ultima_alteracao; set => ultima_alteracao = value; }
    }
}
