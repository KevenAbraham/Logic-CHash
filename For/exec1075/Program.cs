namespace exec1075 {
    internal class Program {
        public static void Main(string[] args) {
            int n;

            Console.WriteLine(("Informe o valor: "));
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++) {
                if (i % n == 2) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}