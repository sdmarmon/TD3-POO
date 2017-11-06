using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Domain;

namespace DAL
{
    public class ReservationRepository : IReservationRepository
    {
        private List<Reservation> reservationList;
        private string filePath;

        public ReservationRepository()
        {
            filePath = @"reservations.xml";
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                reservationList = (List<Reservation>)new XmlSerializer(typeof(List<Reservation>)).Deserialize(reader);
                reader.Close();
            }
            else
            {
                // Fill the list with sample data
                reservationList = new List<Reservation>();
            }
        }

        public List<Reservation> GetAll()
        {
            return reservationList;
        }
    }
}
