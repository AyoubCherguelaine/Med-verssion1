using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_verssion1.PatientSys
{
   public class PatientParametre
    {

        public int idPatientParametre;
        public double Pois;
        public double TenssionSy, TenssionDi;
        public double Temperature;
        public DateTime Date;

       

        static public PatientParametre Get(int id)
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

        static public void Install(PatientParametre PatientParametre)
        {

        }

        static public void Update(int id, PatientParametre PatientParametre)
        {


        }

        static public void Delete(int id)
        {

        }

        static public void Delete(PatientParametre PatientParametre)
        {

        }
    }
}
