namespace aoc25
{
    class Program
    {
        static void Main(string[] args)
        {
            var dec1 = new Dec1("days/dec1.txt");
            int result = dec1.Run();
            System.Console.WriteLine($"Result: {result}");
        }
    }
}
