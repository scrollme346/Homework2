internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number");
        string? oneN = Console.ReadLine();//допускаем что может вводится не только строка, ожидаем ввод текста/цифры
        
        Console.WriteLine("Enter the second number");
        string? twoN = Console.ReadLine();
        
        Console.WriteLine("Enter the third number");
        string? threeN = Console.ReadLine();
        
        Console.WriteLine("Enter the fourth number");
        string? fourN = Console.ReadLine();

        Console.WriteLine("Your numbers");
        Console.WriteLine(oneN + twoN + threeN + fourN);//выводим числа полученые с переменных
    }
}
