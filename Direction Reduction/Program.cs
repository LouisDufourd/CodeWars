namespace DirectionsReduction
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            string[] arr = ["NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"];
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