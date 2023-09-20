namespace execVet5 {
    class Program {
        static void Main(string[] args) {
            int n; 
            double media = 0, soma = 0;

            Console.WriteLine("Informe a quantidade de valores para serem lidos: ");
            n = int.Parse(Console.ReadLine());

            double[] num = new double[n];
                    
            string[] vet = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++) {
                num[i] = double.Parse(vet[i]);
            }

            for(int i = 0; i < n; i++) {
                soma += num[i];
            }

            media = soma / n;

            Console.WriteLine($"Média aritmética: {media:F3}");

            Console.WriteLine("Elementos abaixo da média:");

            for (int i = 0; i < n; i++) {
                if (num[i] < media) {
                    Console.WriteLine(num[i]);
                }
            }
            
        }
    }
}