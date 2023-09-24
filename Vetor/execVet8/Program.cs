namespace execVet8 {
    class Program {
        static void Main(string[] args) {
            int n;

            Console.WriteLine("Informe a quantidade de pessoas:");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];
            double[] media = new double[n];
            for(int i = 0; i < n; i++) {
                string[] vetor = Console.ReadLine().Split(' ');
                nome[i] = vetor[0];
                nota1[i] = double.Parse(vetor[1]);
                nota2[i] = double.Parse(vetor[2]);
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < n; i++) {
                media[i] = (nota1[i] + nota2[i]) / 2;
                if (media[i] >= 6) {
                    Console.WriteLine($"{nome[i]}");
                }
            }
        }
    }
}