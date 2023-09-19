namespace exec1080 {
    internal class Program {
        public static void Main(string[] args) {
            int maior = 0, menor = 9999999, num;

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"Informe {i}º número:");
                num = int.Parse(Console.ReadLine());

                if (num > maior) {
                    maior = num;
                }

                if (num < menor) {
                    menor = num;
                }
            }

            Console.WriteLine($"Maior número: {maior}\nMenor número: {menor}");
            

        }
    }
}