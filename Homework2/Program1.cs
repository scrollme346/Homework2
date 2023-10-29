internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter 6-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());//конвертируем string в int

        int num0 = number / 100000; // получаем первую цифру числа
        int num1 = number / 10000 % 10; // получаем вторую цифру числа
        int num2 = number % 10000 / 1000; // получаем третью цифру числа
        int num3 = number % 1000 / 100; // получаем четвертую цифру числа
        int num4 = number % 100 / 10; // получаем пятую цифру числа 
        int num5 = number % 10; // получаем шестую цифру числа 

        Console.WriteLine("Your number's backwards");
        Console.WriteLine($"{num5}{num4}{num3}{num2}{num1}{num0}");//выводим результат в обратном порядке
    }
}
