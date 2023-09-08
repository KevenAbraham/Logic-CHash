using System.Globalization;

namespace exec14 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Insira o primeiro valor: ");
            double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o segundo valor: ");
            double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o terceiro valor: ");
            double y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o quarto valor: ");
            double y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine($"Valor final: {distance:F4}");
        }
    }
}