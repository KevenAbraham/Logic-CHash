namespace execVet2 {
    class Program {
        static void Main(string[] args) {
            int n, qtd = 0;
            int[] vet;

            Console.WriteLine("Informe a quantidade de valores que irá inserir:");
            n = int.Parse(Console.ReadLine());

            vet = new int[n];

            for (int i = 0; i < n; i++) {
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++) {
                if (vet[i] % 2 == 0) {
                    Console.Write(vet[i] + " ");
                    qtd++;                    
                }
            }

            Console.WriteLine($"\nQuantidade: {qtd}");
        }
    }
}