namespace exec1078 {
    internal class Program {
        public static void Main(string[] args) {
            int n;

            Console.WriteLine("Insira o valor:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                int resultado = i * n;

                Console.WriteLine($"{i} x {n} = {resultado}");
            }

        }
    }
}