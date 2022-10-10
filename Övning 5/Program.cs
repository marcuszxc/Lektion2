namespace Övning_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CarsForHier!!!\n");
            Console.WriteLine("How many days do you want to hire our car.");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("How many km are you going to drive");
            float km = float.Parse(Console.ReadLine());
            Console.WriteLine($"Det kommer att kosta :) : {300 + km + (500 * (days - 1))}kr");

        }
    }
}