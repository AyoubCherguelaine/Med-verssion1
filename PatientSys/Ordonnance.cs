using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_verssion1.PatientSys
{
  public class Ordonnance
    {

        public int idOrdonnance;
        public DateTime DateOrdonnance;
        public string CodeOrdonnance;
        public Dictionary<int,string> Prescrire;

     

        static public Ordonnance Get(int id)
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

        static public void Install(Ordonnance Ordonnance)
        {

        }

        static public void Update(int id, Ordonnance Ordonnance)
        {


        }

        static public void Delete(int id)
        {

        }

        static public void Delete(Ordonnance Ordonnance)
        {

        }
    }
}
