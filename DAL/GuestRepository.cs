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
    public class GuestRepository : IGuestRepository
    {
        private List<Guest> guestList;
        private string filePath;

        public GuestRepository()
        {
            filePath = @"guests.xml";
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                guestList = (List<Guest>)new XmlSerializer(typeof(List<Guest>)).Deserialize(reader);
                reader.Close();
            }
            else
            {
                // Fill the list with sample data
                guestList = new List<Guest>();
                guestList.Add(new Guest("Pesquet", "Baptiste", "Nicaragua"));
            }
        }

        public List<Guest> GetAll()
        {
            return guestList;
        }
    }
}
