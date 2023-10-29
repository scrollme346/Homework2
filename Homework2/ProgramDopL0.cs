internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите 3-х значное число");
        int number = Convert.ToInt32(Console.ReadLine());//конвертируется String в Int

        int zeroN = number / 100;//получаем первое число;
        int oneN = number % 100 / 10;//получаем второе число
        int twoN = number % 10;// получаем третье число

        int sum = zeroN + oneN + twoN;//Сумма чисел
        float arith = sum / 3f; //сред арифмет число
        Console.WriteLine($"Сумма чисел: {sum} \nСреднее арифметическое: {arith}");//вывод числа с переносом строки
    }
}
