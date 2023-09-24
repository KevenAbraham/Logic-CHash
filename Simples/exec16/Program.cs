using System.Globalization;

namespace exec16 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Informe o seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Informe o seu salário: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor da quantidade total de vendas feita no mês: ");
            double totalSells = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salaryInMonth = salary + (totalSells * 0.15);

            Console.WriteLine($"O salário total do mês é R${salaryInMonth:F2}.");
        }
    }
}