using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_verssion1.PatientSys
{
   public class Consultation
    {

        public int idConsultation;
        public DateTime DateConsultation;
        public string DescribeConsultation;
        public string TypeConsultation;

        private Rendez_vous Rendez_;
       
        public Rendez_vous Rendez_vous
        {
            get => Rendez_;
            set
            {
                Rendez_ = value;
            }
        }

        public Consultation()
        {

        }
        public Consultation(int id,DateTime date,string DescribeConsultation)
        {

        }
        static public Consultation Get(int id)
        {
            // get this element by id
            Consultation consultation = new Consultation();

            return null;
            // get this element by id
        }

        static public ArrayList Get()
        {
            // get this element by id

            return null;
            // get this element by id
        }

        static public void Install(Consultation Consultation)
        {

        }

        static public void Update(int id, Consultation Consultation)
        {


        }

        static public void Delete(int id)
        {

        }

        static public void Delete(Consultation Consultation)
        {

        }

    }
}
