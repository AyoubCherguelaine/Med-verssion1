using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Med_verssion1.Database {
    public class ConnectionSql {

        public static ConnectionSql ServerMysql;

        private string server, password, user, database, port;

        public MySqlConnection con;
        private MySqlCommand com;
        public ConnectionSql (string server, string password, string user, string database, string port) {
            this.server = server;
            this.password = password;
            this.user = user;
            this.database = database;
            this.port= port;
            Connecte ();

        }

        private void Connecte () {
            try {
                string connectionString = @"server =" + server + ";port = " + port + " ; uid =" + user + ";pwd=" + password + ";database =" + database + ";charset = utf8;SslMode=none;";
                con = new MySqlConnection (connectionString);
                con.Open ();

            } catch (MySqlException e) {
                Console.WriteLine(e.Message);
            }
        }

        public DataTable GetTable (string command) {
            DataTable r = new DataTable ();

            MySqlDataAdapter adapter = new MySqlDataAdapter (command, con);
            adapter.Fill (r);

            return r;
        }

       

        public void ExcuteCommand (string command) {
           
            com = con.CreateCommand ();
            com.CommandText = command;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery ();
        }
        public void CloseConnection () {
            con.Close ();
        }

    }
}