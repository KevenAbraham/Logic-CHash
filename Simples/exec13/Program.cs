using System.Globalization;

namespace exec13 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Informe a distância em Km: (Inteiro)");
            int distance = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a quantidade de gasolina: ");
            double gas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalSpent = distance / gas;

            Console.WriteLine($"O total de combustível gasto é {totalSpent:F3} km/L");

        }
    }
}