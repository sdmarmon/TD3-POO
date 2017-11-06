using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Room
    {
        //proprietes
        public string Code { get; set; }

        public int Floor { get; set; }
        
        //Constructeurs
        public Room()
        {
            Code = "A0";
            Floor = 0;
        }

        public Room(string code, int floor)
        {
            Code = code;
            Floor = floor;
        }

        //methodes
        public override string ToString()
        {
            string st = "Chambre : ";
            st += "\nCode : " + Code + " Floor : " + Floor;
            return st;
        }



    }
}
