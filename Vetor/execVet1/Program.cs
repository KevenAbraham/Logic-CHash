namespace execVet1 {
    class Program {
        static void Main(string[] args) {
            int n, posicao = 0;

            Console.WriteLine("Informe o valor de números decimais:");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];
            double maior = 0.0;

            for (int i = 0; i < n; i++) {
                vet[i] = double.Parse(Console.ReadLine());
                if (vet[i] > maior) {
                    maior = vet[i];
                    posicao = i;
                } 
            }

            Console.WriteLine($"Maior = {maior}");
            Console.WriteLine($"Posição = {posicao}");
        }
    }
}