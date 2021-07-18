using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Med_verssion1.PatientSys
{
    public class Patient
    {
        public static Dictionary<int, Patient> Patients = new Dictionary<int, Patient>();
        public int idPatient;
        public string Nom;
        public string Prenom;
        public string Address;
        public DateTime DateDeNaissance;
        public string NumTel;

        static public Patient Get(int id)
        {
            // get this element by id

            return null;
            // get this element by id
        }

        static public ArrayList Get()
        {
            // get this element by id

            return null;
            // get this element by id
        }

        static public void Install(Patient patient)
        {

        }

        static public void Update(int id, Patient patient)
        {


        }

        static public void Delete(int id)
        {

        }

        static public void Delete(Patient patient)
        {

        }

        public Dictionary<int, string> NomPrenomId()
        {
            string CNom = Nom + " " + Prenom;
            Dictionary<int, string> list = new Dictionary<int, string>();
            list.Add(idPatient, CNom);
            return list;
        }

        private void GetRow(string command)
        {
            MySqlCommand com;
            MySqlConnection con= Database.ConnectionSql.ServerMysql.con;
            com = con.CreateCommand();
            com.CommandText = command;
            com.CommandType = CommandType.Text;
            MySqlDataReader DR = com.ExecuteReader();
            try
            {
                while (DR.Read())
                {
                    int id = DR.GetInt32("IdPatient");
                    string nom = DR.GetString("Nom");
                    string prenom = DR.GetString("Prenom");
                    string Address = DR.GetString("Address");

                }
            }
            catch (MySqlException ee)
            {
                Console.WriteLine(" exception in Get Row : " + ee.HelpLink);
            }
        }
    }
}
