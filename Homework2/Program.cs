internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");
        string? oneN = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        string? twoN = Console.ReadLine();
        Console.WriteLine("Введите третье число");
        string? threeN = Console.ReadLine();
        Console.WriteLine("Введите четвертое число");
        string? fourN = Console.ReadLine();

        Console.WriteLine("Ваши числа");
        Console.WriteLine(oneN + twoN + threeN + fourN);
    }
}
