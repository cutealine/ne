using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie15Var4
{
    public class SemiLuxuryRoom : Room
    {
        public string Amenities { get; set; }

        public SemiLuxuryRoom(int number, int bedCount, WindowOrientation orientation, float priceForDay, string availableFrom, string amenities)
            : base(number, bedCount, orientation, priceForDay, availableFrom)
        {
            Amenities = amenities;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            var amenitiesInfo = $"Удобства: {Amenities}";

            var fullInfo = new List<string>(baseInfo) { amenitiesInfo };
            return fullInfo.ToArray();
        }
    }
}
