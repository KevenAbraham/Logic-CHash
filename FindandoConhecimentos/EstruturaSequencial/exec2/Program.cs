namespace exec2 {
    class Program {
        static void Main(string[] args) {
            double raio, area;

            Console.WriteLine("Informe o valor do raio do círculo: ");
            raio = double.Parse(Console.ReadLine());

            area = 3.14159 * (Math.Pow(raio,2));

            Console.WriteLine($"A={area:F4}");
        }
    }
}