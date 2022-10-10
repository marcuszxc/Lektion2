namespace Övning_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TreOrd = Console.ReadLine();

            string[] TreOrdArr = TreOrd.Split(" ");

            Console.WriteLine($"{TreOrdArr[2]} {TreOrdArr[1]} {TreOrdArr[0]}.");
        }
    }
}