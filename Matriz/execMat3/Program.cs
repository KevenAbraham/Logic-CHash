namespace execmat3 {
    class Program {
        static void Main(string[] args) {
            int n;

            Console.WriteLine("Informe a matriz quadrada: ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];
            for(int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++) {
                    mat[i,j] = int.Parse(vet[j]);
                }
            }

            int[] vetorMaior = new int[n];
            for(int i = 0; i < n; i++) {
                int maior = 0;
                for(int j = 0; j < n; j++) {
                    if(mat[i,j] > maior) {
                        maior = mat[i,j];
                    }
                }
                vetorMaior[i] = maior;
            }

            for(int i = 0; i < n; i++) {
                Console.WriteLine(vetorMaior[i]);
            }
        }
    }
}