namespace exec1051 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("=======================================");
            Console.WriteLine("        Informe o seu salário          ");
            Console.WriteLine("=======================================");

            Console.Write("R$");
            double money = double.Parse(Console.ReadLine());

            if (money <= 2000.00) {
                Console.WriteLine("Isento");
            } else if (money >= 2000.01 && money <= 3000.00) {
                double tax =  money - (money + (money * (8/100)));
                Console.WriteLine($"Taxa de R${money:F2}");
            } else if (money >= 3000.01 && money <= 4500.00) {
                double tax =  money - (money + (money * (18/100)));
                Console.WriteLine($"Taxa de R${money:F2}");
            } else {
                double tax =  money - (money + (money * (28/100)));
                Console.WriteLine($"Taxa de R${money:F2}");         
            }
        }
    }
}