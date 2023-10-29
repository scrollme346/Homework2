internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter 6-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int num0 = number / 100000;

        int num1 = number / 10000 % 10;

        int num2 = number % 10000 / 1000;

        int num3 = number % 1000 / 100;

        int num4 = number % 100 / 10;

        int num5 = number % 10;

        Console.WriteLine("Your number's backwards");
        Console.WriteLine($"{num5}{num4}{num3}{num2}{num1}{num0}");
        

    }
}
