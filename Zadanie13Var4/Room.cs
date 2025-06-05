namespace Zadanie15Var4
{
    public class Room : IComparable<Room>
    {
        public readonly int Number;
        public int BedCount { get; set; }
        public WindowOrientation Orientation { get; set; }
        public float PriceForDay { get; set; }
        public DateTime AvailableFromDate { get; private set; }

        public Room(int number, int bedCount, WindowOrientation orientation, float priceForDay, string availableFrom)
        {
            Number = number;
            BedCount = bedCount;
            Orientation = orientation;
            PriceForDay = priceForDay;

            if (!DateTime.TryParse(availableFrom, out var availableDate))
                throw new ArgumentException("Неверный формат даты освобождения номера");

            AvailableFromDate = availableDate;
        }

        public virtual string[] GetInfo()
        {
            return new string[]
            {
        $"Номер: {Number}",
        $"Кроватей: {BedCount}",
        $"Ориентация: {GetOrientationName()}",
        $"Цена за сутки: {PriceForDay}",
        $"Освободится: {AvailableFromDate.ToShortDateString()}"
            };
        }

        private string GetOrientationName()
        {
            return Orientation switch
            {
                WindowOrientation.N => "Север",
                WindowOrientation.S => "Юг",
                WindowOrientation.W => "Запад",
                WindowOrientation.E => "Восток"
            };
        }

        public int CompareTo(Room? other)
        {
            if (other == null) return 1;
            return this.Number.CompareTo(other.Number);
        }
    }
}
