namespace _04._SwapMethod
{
    class Box<T>
    {
        private T data;

        public Box(T data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return $"{data.GetType().FullName}: {data}";
        }
    }
}
