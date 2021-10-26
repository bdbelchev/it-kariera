using System;

namespace _05._UniversalScale
{
    class Scale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T getHeavier()
        {
            if (left.CompareTo(right) == 0)
            {
                return default;
            }

            return left.CompareTo(right) > 0 ? left : right;
        }
    }
}
