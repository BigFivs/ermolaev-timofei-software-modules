namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("z1 = ");
            double z1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("z2 = ");
            double z2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("z3 = ");
            double z3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("z4 = ");
            double z4 = Convert.ToDouble(Console.ReadLine());

            double e1 = Math.Exp(z1);
            double e2 = Math.Exp(z2);
            double e3 = Math.Exp(z3);
            double e4 = Math.Exp(z4);

            double S = e1 + e2 + e3 + e4;

            double p1 = e1 / S;
            double p2 = e2 / S;
            double p3 = e3 / S;
            double p4 = e4 / S;

            double P = p1 + p2 + p3 + p4;

            Console.WriteLine($"p1 = {p1}");
            Console.WriteLine($"p2 = {p2}");
            Console.WriteLine($"p3 = {p3}");
            Console.WriteLine($"p4 = {p4}");
            Console.WriteLine($"Сумма вероятностей = {P}");
        }
    }
}
