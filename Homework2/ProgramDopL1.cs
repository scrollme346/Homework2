internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Цена ноутбука");
        int price = Convert.ToInt32(Console.ReadLine());//конвертируется String в Int

        Console.WriteLine("Количетсво");
        int quantity = Convert.ToInt32(Console.ReadLine());//конвертируется String в Int

        Console.WriteLine("Процент скидки");
        double rate = Convert.ToDouble(Console.ReadLine());//конвертируется String в Double

        int sumOne = price * quantity;//цену ноутбука умножаем на количество
        double procent = (rate / 100) * sumOne;// высчитываем процент
        double result = sumOne - procent;// от суммы заказа отнимаем процент

        Console.WriteLine($"Сумма заказа(без скидки) {sumOne} \nСумма заказа: {result} \nСумма выбитой скидки:{procent}");// выводим информацию о заказе(очень удобно лучше чем писать каждый раз Console)
    }
}
