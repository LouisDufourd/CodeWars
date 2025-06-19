using CodeWars;

namespace DrivingLiscence
{
    class Program
    {
        public static void Main()
        {
            Kata test = new Kata();
            string[] data = ["Johanna", "", "Gibbs", "13-Dec-1981", "F"];
            Console.WriteLine(test.driver(data));
        }
    }
}