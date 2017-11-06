using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Guest
    {
        //proprietes
        public string Country { get; set; }

        public string Firstname { get; set; }

        public string LastName { get; set; }


        //constructeurs
        public Guest()
        {
            Country = "France";
            Firstname = "Chel";
            LastName = "Mi";
        }

        public Guest(string lastn, string firstn, string country)
        {
            Country = country;
            Firstname = firstn;
            LastName = lastn;
        }

        //methodes
        public override string ToString()
        {
            string st = "Guest : ";
            st += "\nNom : " + LastName + " Prenom : " + Firstname ;
            st += "\nPays : " + Country;
            return st;
        }

    }
}
