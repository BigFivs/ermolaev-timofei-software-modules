namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а1");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число а2");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число а3");
            double a3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b1");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b2");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b3");
            double b3 = double.Parse(Console.ReadLine());
            double scalar = a1 * b1 + a2 * b2 + a3 * b3;
            double lengthA = Math.Sqrt(
                Math.Pow(a1, 2) +
                Math.Pow(a2, 2) +
                Math.Pow(a3, 2)
                );
            double lengthB = Math.Sqrt(
                Math.Pow(b1, 2) +
                Math.Pow(b2, 2) +
                Math.Pow(b3, 2)
                );
            double cosA = scalar / (lengthA * lengthB);
            double angel = Math.Acos(cosA);
            Console.WriteLine($"Скалярное произведение = {scalar}");
            Console.WriteLine($"Длинна А = {lengthA}");
            Console.WriteLine($"Длинна B = {lengthB}");
            Console.WriteLine($"cos(A) = {cosA}");
            Console.WriteLine($"угол в радианах = {angel}");

        }
    }
}
