namespace exec8 {
    internal class Program {
        public static void Main(string[] args) {
            int a, b, c, d, diff;

            Console.WriteLine("Informe o primeiro valor a ser lido pelo console: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro valor a ser lido pelo console: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro valor a ser lido pelo console: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro valor a ser lido pelo console: ");
            d = int.Parse(Console.ReadLine());

            diff = (a * b - c * d);

            Console.WriteLine("A diferença entre A * B - C * D é: " + diff);
        }
    }
}