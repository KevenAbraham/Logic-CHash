namespace exec1045 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Informe o primeiro valor do triângulo:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro valor do triângulo:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro valor do triângulo:");
            double c = double.Parse(Console.ReadLine());

            if(a >= (b + c)) {
                Console.WriteLine("Não forma triângulo");
            } else if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 3))) {
                Console.WriteLine("Triângulo Retângulo");
            } else if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 3))) {
                Console.WriteLine("Triângulo Obtusângulo");
            } else if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 3))) {
                Console.WriteLine("Triângulo Actuangulo");
            } else if (a == b && a == c) {
                Console.WriteLine("Triângulo Equilátero");
            } else if (a == b || a == c || c == b) {
                Console.WriteLine("Triângulo Isóceles");
            }
        }
    }
}