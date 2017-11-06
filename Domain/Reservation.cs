using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Reservation
    {
        //proprietes
        public Guest Invite { get; set; }

        public Room Chambre { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartDate { get; set; }


        //constructeurs
        public Reservation()
        {
            Invite = new Guest();
            Chambre = new Room();
            EndDate = new DateTime(2017,12,25);
            StartDate = new DateTime(2017,11,6);
        }

        public Reservation(Guest guest, Room room, DateTime startDate, DateTime endDate)
        {
            Invite = guest;
            Chambre = room;
            StartDate = startDate;
            EndDate = endDate;

        }
    }
}
