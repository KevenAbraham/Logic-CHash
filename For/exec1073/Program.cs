namespace exec1073 {
    internal class Program {
        public static void Main(string[] args) {
            int num;

            Console.WriteLine("Informe o valor para ser lido: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine($"{i} ^ 2 = {Math.Pow(i,2)}");
                }
            }
        }
    }
}