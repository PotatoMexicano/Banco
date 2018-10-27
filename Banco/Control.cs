using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banco
{
    static class Control
    {
        static MySqlConnection conn = new MySqlConnection("server=sql157.main-hosting.eu;port=3306;User Id=u736501739_team;database=u736501739_bank;password=Pimenta10");

        static public bool conectar()
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

        static public Usuario login(int agencia, int conta, string senha)
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
                Usuario usuario = new Usuario(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetInt32(5), r.GetInt32(6), r.GetString(7), r.GetInt32(8), r.GetChar(9), r.GetInt32(10));
                conn.Close();
                return usuario;

            }
            else
            {
                conn.Close();
                return null;
            }
        }
    }
}
