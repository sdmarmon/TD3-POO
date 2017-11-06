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
    public class RoomRepository : IRoomRepository
    {
        private List<Room> roomList;
        private string filePath;

        public RoomRepository()
        {
            filePath = @"rooms.xml";
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                roomList = (List<Room>)new XmlSerializer(typeof(List<Room>)).Deserialize(reader);
                reader.Close();
            }
            else
            {
                // Fill the list with sample data
                roomList = new List<Room>();
                roomList.Add(new Room("A1", 0));
                roomList.Add(new Room("A2", 0));
            }
        }

        public List<Room> GetAll()
        {
            return roomList;
        }
    }
}
