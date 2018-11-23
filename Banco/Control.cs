using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Banco
{
    static class Control
    {
        static MySqlConnection conn = new MySqlConnection("server=sql157.main-hosting.eu;port=3306;User Id=u736501739_team;database=u736501739_bank;password=Pimenta10");

        public static bool Conectar()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Usuario Login(int agencia, int conta, string senha)
        {
            MySqlCommand command = new MySqlCommand();
            conn.Open();
            command.Connection = conn;
            command.Parameters.Add("@agencia", MySqlDbType.Int32).Value = agencia;
            command.Parameters.Add("@conta", MySqlDbType.Int32).Value = conta;
            command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senha;
            command.CommandText = "SELECT * FROM usuarios where agencia = @agencia AND conta = @conta AND senha = @senha";

            
            MySqlDataReader r = command.ExecuteReader();
            if (r.Read())
            {
                Usuario usuario = new Usuario(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetInt32(5), r.GetInt32(6), r.GetString(7), r.GetInt32(8), r.GetChar(9), r.GetInt32(10), r.GetDateTime(11));
                conn.Close();
                return usuario;

            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public static void Cadastrar(string nome, string sobrenome, string cpf, string rg, int agencia, string senha, int tipo, char sexo, int idade, int conta)
        {

            MySqlCommand signup = new MySqlCommand();
            conn.Open();
            signup.Connection = conn;
            signup.Parameters.AddWithValue("@nome", nome);
            signup.Parameters.AddWithValue("@sobrenome", sobrenome);
            signup.Parameters.AddWithValue("@cpf", cpf);
            signup.Parameters.AddWithValue("@rg", rg);
            signup.Parameters.Add("@agencia", MySqlDbType.Int32).Value = agencia;
            signup.Parameters.AddWithValue("@senha", senha);
            signup.Parameters.Add("@tipo", MySqlDbType.Int32).Value = tipo;
            signup.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = sexo;
            signup.Parameters.Add("@idade", MySqlDbType.Int32).Value = idade;
            signup.Parameters.Add("@conta", MySqlDbType.Int32).Value = conta;

            signup.CommandText = "INSERT INTO usuarios VALUES ('',@nome,@sobrenome,@cpf,@rg,@conta,@agencia,@senha,@tipo,@sexo,@idade,CURRENT_TIMESTAMP)";
            signup.ExecuteNonQuery();
            conn.Close();
        }

        public static void Criar_Conta(int tipo, int id)
        {
            MySqlCommand cc = new MySqlCommand();
            conn.Open();
            cc.Connection = conn;
            cc.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            if (tipo == 0)
            {
                cc.CommandText = "INSERT INTO corrente VALUES ('',@id, 0, CURRENT_TIMESTAMP)";

            }else if (tipo == 2)
            {
                cc.CommandText = "INSERT INTO corrente VALUES ('',@id, 0, CURRENT_TIMESTAMP); INSERT INTO poupança VALUES ('',@id, 0, CURRENT_TIMESTAMP)";
            }
            else
            {
                cc.CommandText = "INSERT INTO poupança VALUES ('',@id, 0, CURRENT_TIMESTAMP)";
            }
            cc.ExecuteNonQuery();
            conn.Close();
        }

        public static Conta Extrato(int id)
        {
                MySqlCommand extrato = new MySqlCommand();
                conn.Open();
                extrato.Connection = conn;
                extrato.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                extrato.CommandText = "SELECT * FROM corrente WHERE id_usuario = @id";

                MySqlDataReader r = extrato.ExecuteReader();
                if (r.Read())
                {
                    Conta conta = new Conta(r.GetInt32(0), r.GetInt32(1), r.GetDouble(2), r.GetDateTime(3));
                    conn.Close();
                    return conta;
                }
                else
                {
                    conn.Close();
                    return null;
                }
        }

        public static Conta Extrato_Poup(int id)
        {
            MySqlCommand poup = new MySqlCommand();
            conn.Open();
            poup.Connection = conn;
            poup.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            poup.CommandText = "SELECT * FROM poupança WHERE id_usuario = @id";

            MySqlDataReader r = poup.ExecuteReader();
            if (r.Read())
            {
                Conta conta = new Conta(r.GetInt32(0), r.GetInt32(1), r.GetDouble(2), r.GetDateTime(3));
                conn.Close();
                return conta;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public static DataTable Historico_Corrente(int id, int conta)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM extratos WHERE id_usuario = "+id+" AND numero_conta = "+conta+" ORDER BY ultimo_acesso DESC;", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public static void Depositar(double valor, int id, int tipo, int conta)
        {
            MySqlCommand dep = new MySqlCommand();
            conn.Open();
            dep.Connection = conn;
            dep.Parameters.Add("@valor", MySqlDbType.Double).Value = valor;
            dep.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            dep.Parameters.Add("@conta", MySqlDbType.Int32).Value = conta;
            if (tipo == 0 )
            {
                dep.CommandText = "UPDATE corrente SET saldo = saldo + @valor, ultima_alteracao = CURRENT_TIMESTAMP WHERE id_usuario = @id; INSERT INTO extratos  VALUES ('', @id, @conta, 'Deposito', @valor, CURRENT_TIMESTAMP);";
            }
            else
            {
                dep.CommandText = "UPDATE poupança SET saldo = saldo + @valor, ultima_alteracao = CURRENT_TIMESTAMP WHERE id_usuario = @id; INSERT INTO extratos  VALUES ('', @id, @conta, 'Deposito', @valor, CURRENT_TIMESTAMP);";
            }
            
            dep.ExecuteNonQuery();
            conn.Close();
        }

        public static void Sacar(int id, double valor, int tipo, int conta)
        {
            MySqlCommand sacar = new MySqlCommand();
            conn.Open();
            sacar.Connection = conn;
            sacar.Parameters.Add("@valor", MySqlDbType.Double).Value = valor;
            sacar.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            sacar.Parameters.Add("@conta", MySqlDbType.Int32).Value = conta;
            if (tipo == 0)
            {
                sacar.CommandText = "UPDATE corrente SET saldo = saldo - @valor, ultima_alteracao = CURRENT_TIMESTAMP WHERE id_usuario = @id; INSERT INTO extratos  VALUES ('', @id, @conta, 'Saque', @valor, CURRENT_TIMESTAMP);";
            }
            else
            {
                sacar.CommandText = "UPDATE poupança SET saldo = saldo - @valor, ultima_alteracao = CURRENT_TIMESTAMP WHERE id_usuario = @id; INSERT INTO extratos  VALUES ('', @id, @conta, 'Saque', @valor, CURRENT_TIMESTAMP);";
            }
            
            sacar.ExecuteNonQuery();
            conn.Close();
        }

        public static void Atualiza_Data_Login(int id)
        {
            MySqlCommand att = new MySqlCommand();
            att.Connection = conn;
            conn.Open();
            att.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            att.CommandText = "UPDATE usuarios SET ultimo_acesso = CURRENT_TIMESTAMP WHERE id = @id";
            att.ExecuteNonQuery();
            conn.Close();
        }

        public static void Remover_Conta(int id, string senha, string cpf, int tipo)
        {
            MySqlCommand rm = new MySqlCommand();
            rm.Connection = conn;
            conn.Open();
            rm.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            rm.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senha;
            rm.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
            rm.CommandText = "DELETE FROM usuarios WHERE id = @id AND senha = @senha AND cpf = @cpf";
            rm.ExecuteNonQuery();


            MySqlCommand rmc = new MySqlCommand();
            rmc.Connection = conn;
            rmc.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            if (tipo == 0)
            {
                rmc.CommandText = "DELETE FROM corrente WHERE id_usuario = @id";
            }
            else if (tipo == 1)
            {
                rmc.CommandText = "DELETE FROM poupança WHERE id_usuario = @id";
            }
            else if (tipo == 2)
            {
                rmc.CommandText = "DELETE FROM corrente WHERE id_usuario = @id;DELETE FROM poupança WHERE id_usuario = @id";
            }
            rmc.ExecuteNonQuery();

        }
    }
}
