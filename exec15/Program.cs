namespace exec15 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Informe a duração da viagem em horas:");
            int hour = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a média de Litros por Km: ");
            int liter = int.Parse(Console.ReadLine());

            double distance = hour * liter;

            double avgLiter = distance / 12.0;

            Console.WriteLine($"Média de litros nessa viagem é de: {avgLiter:F3} km/L.");
        }
    }
}