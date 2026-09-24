namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("V = ");
            double V = Convert.ToDouble(Console.ReadLine());

            Console.Write("D = ");
            double D = Convert.ToDouble(Console.ReadLine());

            Console.Write("B = ");
            double B = Convert.ToDouble(Console.ReadLine());

            double P = V * D;

            double Memory = P * B / Math.Pow(1024, 2);

            Console.WriteLine($"Количество параметров = {P}");
            Console.WriteLine($"Объём памяти = {Memory} + МБ");
        }
    }
}
