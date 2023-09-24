using System.Globalization;

namespace exec9 {
    internal class Program {
        public static void Main(string[] args) {
            ///calculo de salário 
            Console.WriteLine("Informe o seu serial de cadastro: ");
            int serial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas trabalhadas no mês: ");
            int hour = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade recebida por hora: ");
            double salaryPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salaryTotal = salaryPerHour * hour;

            Console.WriteLine("Serial de cadastro: " + serial);
            Console.WriteLine("Total de Salário: R$" + salaryTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}