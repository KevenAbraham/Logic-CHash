namespace execVet6 {
    internal class Program {
        static void Main(string[] args) {
            int n, soma = 0, totalPar = 0;
            double media = 0.0;

            Console.WriteLine("Informe a quantidade de valores que entrará no programa");
            n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            string[] elementos = Console.ReadLine().Split(' ');
            
            for(int i = 0; i < n; i++) {
                vetor[i] = int.Parse(elementos[i]);
            }

            for(int i = 0; i < n; i++) {
                if (vetor[i] % 2 == 0) {
                    soma += vetor[i];
                    totalPar++;
                }
            }

            media = soma / totalPar;

            Console.WriteLine($"A média dos valores pares é: {media:F2}");

            
        }
    }
}