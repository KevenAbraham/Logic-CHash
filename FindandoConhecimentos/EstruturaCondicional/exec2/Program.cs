namespace exec2 {
    internal class Program {
        static void Main(string[] args) {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("Informe o valor de A, B e C");
            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            if (a == 0.0) {
                Console.WriteLine("Impossível Calcular.");
            } else {
                delta = Math.Pow(b,2) - 4 * a * c;
                if(delta < 0) {
                    Console.WriteLine("Impossível Calcular.");
                } else {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"X1 = {x1:F4}");
                    Console.WriteLine($"X2 = {x2:F4}");
                }
            }


        }
    }
}