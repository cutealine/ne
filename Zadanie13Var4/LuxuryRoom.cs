using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14Var4
{
    public class LuxuryRoom : SemiLuxuryRoom
    {
        public int RoomCount { get; set; }
        public int MinBookingDays { get; set; }

        public LuxuryRoom(int number, int bedCount, WindowOrientation orientation, float priceForDay, string availableFrom, string amenities, int roomCount, int minBookingDays)
            : base(number, bedCount, orientation, priceForDay, availableFrom, amenities)
        {
            RoomCount = roomCount;
            MinBookingDays = minBookingDays;
        }
        
        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            var extraInfo = new[]
            {
                $"Комнат: {RoomCount}",
                $"Мин. срок брони: {MinBookingDays} дней"
            };

            var fullInfo = new List<string>(baseInfo);
            fullInfo.AddRange(extraInfo);
            return fullInfo.ToArray();
        }
    }
}
