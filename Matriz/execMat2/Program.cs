namespace execmat2 {
    class Program {
        static void Main(string[] args) {
            int n;

            Console.WriteLine("Informe a matriz quadrada: ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];
            for(int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++) {
                    mat[i,j] = int.Parse(s[j]);
                }
            }

            int[] vetSoma = new int[n];

            for(int i = 0; i < n; i++) {
                int soma = 0;
                for(int j = 0; j < n; j++) {
                    soma = soma + mat[i,j];
                }
                vetSoma[i] = soma;
            }

            for(int i = 0; i < n; i++) {
                Console.WriteLine(vetSoma[i]);
            }
        }
    }
}