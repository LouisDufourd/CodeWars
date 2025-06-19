namespace SortOdd {
    class Program
    {
        public static void Main(string[] args)
        {
            int[] sorted = Kata.SortArray([9, 8, 7, 6, 5, 4, 3, 2, 1, 0]);
            Console.Write("[");
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write(sorted[i]);
                if(i < sorted.Length - 1) {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }
    }
}