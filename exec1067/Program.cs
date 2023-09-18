namespace exec1067 {
    internal class Program {
        public static void Main(string[] args) {
            int num;

            Console.WriteLine("\nInforme o valor para ser ver os seus ímpares entre 1 e ele");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                if (i % 2 != 0) {
                    Console.Write(i + " ");
                }
            }
        }
    }
}