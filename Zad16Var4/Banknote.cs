using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad16Var4
{
    public class Banknote
    {
        private static readonly int[] ValidValues = { 1, 2, 5, 10, 50, 100, 200, 500, 1000, 2000, 5000 };

        public int Value { get; }

        public Banknote(int value)
        {
            if (!ValidValues.Contains(value))
                throw new ArgumentException("Недопустимый номинал банкноты");

            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj is Banknote other)
                return this.Value == other.Value;

            return false;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator ==(Banknote a, Banknote b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Value == b.Value;
        }

        public static bool operator !=(Banknote a, Banknote b) => !(a == b);

        public static int operator *(Banknote note, int count)
        {
            return note.Value * count;
        }

        public static int operator *(int count, Banknote note)
        {
            return note.Value * count;
        }
    }
}
