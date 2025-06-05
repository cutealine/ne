using NUnit.Framework;
using System;

namespace Zadanie13Var4.UnitTests
{
    [TestFixture]
    public class RoomUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var room = CreateTestRoom();

            Assert.That(room.Number, Is.EqualTo(10));
            Assert.That(room.BedCount, Is.EqualTo(2));
            Assert.That(room.Orientation, Is.EqualTo(WindowOrientation.N));
            Assert.That(room.PriceForDay, Is.EqualTo(2500));
            Assert.That(room.AvailableFromDate.ToShortDateString(), Is.EqualTo("10.06.2025"));
        }

        [Test]
            public void GetInfoTest()
        {
            var room = CreateTestRoom();
            var info = room.GetInfo();

            Assert.That(info.Length, Is.EqualTo(5));
            Assert.That(info[0], Is.EqualTo("Номер: 10"));
            Assert.That(info[1], Is.EqualTo("Кроватей: 2"));
            Assert.That(info[2], Is.EqualTo("Ориентация: Север"));
            Assert.That(info[3], Is.EqualTo($"Цена за сутки: {room.PriceForDay}"));
            Assert.That(info[4], Is.EqualTo($"Освободится: {room.AvailableFromDate.ToShortDateString()}"));
        }

        private Room CreateTestRoom()
        {
            return new Room(10, 2, WindowOrientation.N, 2500, "10.06.2025");
        }
    }
}