using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie15Var4
{
    public class Hotel : IEnumerable<Room>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int RoomCount => _rooms.Count;

        private List<Room> _rooms;

        public Hotel(string name, string address, IEnumerable<Room> rooms)
        {
            Name = name;
            Address = address;
            _rooms = new List<Room>(rooms);
        }

        public IEnumerator<Room> GetEnumerator()
        {
            return _rooms.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
