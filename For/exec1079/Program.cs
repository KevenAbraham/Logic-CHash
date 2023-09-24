namespace exec1079 {
    internal class Program {
        public static void Main(string[] args) {
            int n;
            double media = 0.0;
            string[] vet;

            Console.WriteLine("Informe um valor a ser lido:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Informe as três notas separadas por espaço:");
                vet = Console.ReadLine().Split(' ');

                double n1 = double.Parse(vet[0]);
                double n2 = double.Parse(vet[1]);
                double n3 = double.Parse(vet[2]);

                media = (n1 + n2 + n3) / 3;
                Console.WriteLine("Média das médias: " + media.ToString("F1")); // Exibe a média com uma casa decimal
            }


        }
    }
}