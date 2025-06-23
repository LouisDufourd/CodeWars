namespace DirectionsReduction
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            string[] arr = ["EAST", "WEST", "EAST", "NORTH", "WEST", "WEST", "EAST", "SOUTH"];
            string[] res = DirReduction.dirReduc(arr);

            Console.Write("[");

            for (int i = 0; i < res.Count(); i++)
            {
                Console.Write($"\"{res.ElementAt(i)}\"");

                if (i != res.Count() - 1) Console.Write(", ");
            }

            Console.WriteLine("]");
        }
    }
}