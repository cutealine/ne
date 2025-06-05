using System;
using Zad16Var4;

namespace BundleStruct
{
    public struct Bundle
    {
        public Banknote BundleBanknote { get; set; }

        int count;
        public int Count
        {
            get => count;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Значение должно быть неотрицательным");

                count = value;
            }
        }

        public int Sum
        {
            get => BundleBanknote * Count;
        }

        public Bundle(Banknote bundleBanknote, int count) : this()
        {
            BundleBanknote = bundleBanknote;
            Count = count;
        }

        public override string ToString() => $"{Count} x {BundleBanknote} р.\"";

        public override bool Equals(object obj)
        {
            if (obj is Bundle)
                return (Count == ((Bundle)obj).Count)&&(BundleBanknote == ((Bundle)obj).BundleBanknote);

            throw new ArgumentException("Объект для сравнения не является пачкой денег");
        }

        public override int GetHashCode() => Sum.GetHashCode();

        public static bool operator ==(Bundle x, Bundle y) => x.Equals(y);
        public static bool operator !=(Bundle x, Bundle y) => !x.Equals(y);

        public static Bundle operator +(Bundle x, Bundle y)
        {
            if (x.BundleBanknote != y.BundleBanknote)
                throw new InvalidOperationException("Нельзя складывать пачки с разным номиналом.");

            return new Bundle(x.BundleBanknote, x.Count + y.Count);
        }

        public static Bundle operator -(Bundle x, Bundle y)
        {
            if (x.BundleBanknote != y.BundleBanknote)
                throw new InvalidOperationException("Нельзя вычитать пачки с разным номиналом.");

            if (x.Count < y.Count)
                throw new InvalidOperationException("Нельзя вычитать пачку с большим количеством купюр.");

            return new Bundle(x.BundleBanknote, x.Count - y.Count);
        }

    }
}
