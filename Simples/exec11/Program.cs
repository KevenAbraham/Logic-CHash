namespace exec11 {
    internal class Program {
        public static void Main(string[] args) {
            double pi = 3.14159;

            Console.Write("Digite o valor do raio (R): ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double volume = (4.0 / 3.0) * pi * Math.Pow(radius, 3);

            Console.WriteLine($"O volume da esfera com raio {radius} é: {volume:F3}");
        }
    }
}