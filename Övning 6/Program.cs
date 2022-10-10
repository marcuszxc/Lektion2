namespace Övning_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string UserInput = Console.ReadLine();

            UserInput = UserInput.Trim();

            string[] SplitUserInput = UserInput.Split('*');

            Console.WriteLine(double.Parse(SplitUserInput[0]) * double.Parse(SplitUserInput[1]));
        }
    }
}