namespace CategorizeNewMember {
    class Program {
        public static void Main(string[] args) 
        {
            var category = Kata.OpenOrSenior([ [45, 12 ], [55, 21], [19, 2], [104, 20] ]);

            Console.Write("[");

            for (int i = 0; i < category.Count(); i++)
            {
                Console.Write($"\"{category.ElementAt(i)}\"");

                if (i != category.Count() - 1) Console.Write(", ");
            }

            Console.WriteLine("]");
        }
    }
}