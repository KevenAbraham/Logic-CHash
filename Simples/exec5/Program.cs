namespace exec5 {
    internal class Program {
        public static void Main(string[] args) {
            int a, b, prod;

            Console.WriteLine("Informe o primeiro valor:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            b = int.Parse(Console.ReadLine());

            prod = a * b;

            Console.WriteLine("O produto entre " + a + " vezes " + b + " é igual a: " + prod);
        }
    }
}