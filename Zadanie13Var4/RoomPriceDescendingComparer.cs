using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie15Var4
{
    public class RoomPriceDescendingComparer : IComparer<Room>
    {
        public int Compare(Room? x, Room? y)
        {
            if (x == null || y == null) return 0;
            return y.PriceForDay.CompareTo(x.PriceForDay); 
        }
    }
}
