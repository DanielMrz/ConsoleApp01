internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj wartość");
        var value = Console.ReadLine();
        Console.WriteLine($"Twoja wartość: {value}");
        Console.WriteLine($"{DateTime.Now:dd-MM-yyy HH:mm} {DateTime.Now.DayOfWeek}");

        var random = new Random();
        Console.WriteLine($"Losowa liczba: {random.Next(0, 10)}");
       Console.ReadLine();
    }
}