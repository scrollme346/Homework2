internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ваша месячная прибыль продаж");
        int profit = Convert.ToInt32(Console.ReadLine());//конвертируется String в Int

        double rate = Convert.ToDouble(5);//перевожу Int в Double

        double procent = (rate / 100) * profit;// вычисление процентов 
        double sum = procent + 100;// прибавление процентов к месячной ЗП

        Console.WriteLine($"Ваш зароботок(с процентами) {sum} \nВаши проценты(за месяц) {procent}");// вывод месячной ЗП с процентами и процентов за месяц
    }
}
