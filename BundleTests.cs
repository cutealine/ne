using NUnit.Framework;
using System;
using Zad16Var4;

namespace BundleStruct.UnitTests
{
    [TestFixture]
    public class BundleTests
    {
        [Test]
        public void ConstructorTest()
        {
            var banknote = new Banknote(100);
            var bundle = new Bundle(banknote, 5);

            Assert.That(bundle.BundleBanknote.Value, Is.EqualTo(100));
            Assert.That(bundle.Count, Is.EqualTo(5));
        }

        [TestCase(-1)]
        [TestCase(-100)]
        public void CountSet_NegativeValue_ThrowsArgumentException(int count)
        {
            var bundle = new Bundle();
            var banknote = new Banknote(10);
            bundle.BundleBanknote = banknote;

            Assert.That(() => bundle.Count = count, Throws.ArgumentException);
        }

        [TestCase(50, 3, 150)]
        [TestCase(1000, 0, 0)]
        [TestCase(5, 7, 35)]
        public void Sum_CalculatesCorrectly(int denomination, int count, int expectedSum)
        {
            var banknote = new Banknote(denomination);
            var bundle = new Bundle(banknote, count);

            Assert.That(bundle.Sum, Is.EqualTo(expectedSum));
        }

        [TestCase(10, 3, "3 x 10 ð.\"")]
        [TestCase(5000, 1, "1 x 5000 ð.\"")]
        public void ToString_ReturnsExpectedFormat(int denomination, int count, string expected)
        {
            var bundle = new Bundle(new Banknote(denomination), count);

            Assert.That(bundle.ToString(), Is.EqualTo(expected));
        }

        [TestCase(100, 5, 100, 5, true)]
        [TestCase(100, 5, 100, 4, false)]
        public void Equals_TwoBundles_ExpectedResult(
            int denom1, int count1, int denom2, int count2, bool expectedEqual)
        {
            var b1 = new Bundle(new Banknote(denom1), count1);
            var b2 = new Bundle(new Banknote(denom2), count2);

            Assert.That(b1.Equals(b2), Is.EqualTo(expectedEqual));
        }

        [Test]
        public void Equals_InvalidArgument_ThrowsArgumentException()
        {
            var bundle = new Bundle(new Banknote(100), 5);
            var obj = new object();

            Assert.That(() => bundle.Equals(obj), Throws.ArgumentException);
        }

        [Test]
        public void OperatorEquality_WorksCorrectly()
        {
            var x = new Bundle(new Banknote(100), 5);
            var y = new Bundle(new Banknote(100), 5);
            var z = new Bundle(new Banknote(50), 5);

            Assert.That(x == y, Is.True);
            Assert.That(x != y, Is.False);
            Assert.That(x == z, Is.False);
            Assert.That(x != z, Is.True);
        }

        [Test]
        public void OperatorPlus_SameDenomination_AddsCorrectly()
        {
            var x = new Bundle(new Banknote(100), 3);
            var y = new Bundle(new Banknote(100), 2);
            var expected = new Bundle(new Banknote(100), 5);

            Assert.That(x + y, Is.EqualTo(expected));
        }

        [Test]
        public void OperatorPlus_DifferentDenomination_ThrowsInvalidOperationException()
        {
            var x = new Bundle(new Banknote(100), 3);
            var y = new Bundle(new Banknote(50), 2);

            Assert.That(() => { var result = x + y; }, Throws.InvalidOperationException);
        }

        [Test]
        public void OperatorMinus_SameDenomination_SubtractsCorrectly()
        {
            var x = new Bundle(new Banknote(100), 5);
            var y = new Bundle(new Banknote(100), 2);
            var expected = new Bundle(new Banknote(100), 3);

            Assert.That(x - y, Is.EqualTo(expected));
        }

        [Test]
        public void OperatorMinus_DifferentDenomination_ThrowsInvalidOperationException()
        {
            var x = new Bundle(new Banknote(100), 5);
            var y = new Bundle(new Banknote(50), 2);

            Assert.That(() => { var result = x - y; }, Throws.InvalidOperationException);
        }

        [Test]
        public void OperatorMinus_SubtractMoreThanAvailable_ThrowsInvalidOperationException()
        {
            var x = new Bundle(new Banknote(100), 2);
            var y = new Bundle(new Banknote(100), 5);

            Assert.That(() => { var result = x - y; }, Throws.InvalidOperationException);
        }
    }
}
