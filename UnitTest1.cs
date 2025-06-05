using NUnit.Framework;
using System;

namespace Zadanie14Var4.UnitTests
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

        [TestFixture]
        public class SemiLuxuryRoomTests
        {
            [Test]
            public void ConstructorTest()
            {
                var room = CreateTestSemiLuxuryRoom();

                Assert.That(room.Number, Is.EqualTo(20));
                Assert.That(room.BedCount, Is.EqualTo(2));
                Assert.That(room.Orientation, Is.EqualTo(WindowOrientation.N));
                Assert.That(room.PriceForDay, Is.EqualTo(5000));
                Assert.That(room.Amenities, Is.EqualTo("Wi-Fi, Телевизор"));
            }

            [Test]
            public void GetInfoTest()
            {
                var room = CreateTestSemiLuxuryRoom();
                var info = room.GetInfo();

                Assert.That(info.Length, Is.EqualTo(6));
                Assert.That(info[0], Is.EqualTo("Номер: 20"));
                Assert.That(info[5], Is.EqualTo("Удобства: Wi-Fi, Телевизор"));
            }

            private SemiLuxuryRoom CreateTestSemiLuxuryRoom()
            {
                return new SemiLuxuryRoom(
                    number: 20,
                    bedCount: 2,
                    orientation: WindowOrientation.N,
                    priceForDay: 5000,
                    availableFrom: "2025-06-10",
                    amenities: "Wi-Fi, Телевизор"
                );
            }

        }
        [TestFixture]
        public class LuxuryRoomTests
        {
            [Test]
            public void ConstructorTest()
            {
                var room = CreateTestLuxuryRoom();

                Assert.That(room.Number, Is.EqualTo(30));
                Assert.That(room.RoomCount, Is.EqualTo(3));
                Assert.That(room.MinBookingDays, Is.EqualTo(2));
                Assert.That(room.Amenities, Is.EqualTo("Wi-Fi, Телевизор, Балкон"));
            }

            [Test]
            public void GetInfoTest()
            {
                var room = CreateTestLuxuryRoom();
                var info = room.GetInfo();

                Assert.That(info.Length, Is.EqualTo(8));
                Assert.That(info[0], Is.EqualTo("Номер: 30"));
                Assert.That(info[5], Is.EqualTo("Удобства: Wi-Fi, Телевизор, Балкон"));
                Assert.That(info[6], Is.EqualTo("Комнат: 3"));
                Assert.That(info[7], Is.EqualTo("Мин. срок брони: 2 дней"));
            }

            private LuxuryRoom CreateTestLuxuryRoom()
            {
                return new LuxuryRoom(
                    number: 30,
                    bedCount: 3,
                    orientation: WindowOrientation.S,
                    priceForDay: 8000,
                    availableFrom: "2025-06-10",
                    amenities: "Wi-Fi, Телевизор, Балкон",
                    roomCount: 3,
                    minBookingDays: 2
                );
            }
        }
    }
}