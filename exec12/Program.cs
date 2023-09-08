namespace exec12 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Informe o primeiro valor:");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o segundo valor:");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o terceiro valor:");
            int c = int.Parse(Console.ReadLine());

            double maior = Math.Max(a, Math.Max(b, c));

            Console.WriteLine($"{maior} foi o maior número digitado.");
        }
    }
}