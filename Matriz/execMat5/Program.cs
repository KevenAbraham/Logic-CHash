namespace execMat5 {
    class Program {
        static void Main(string[] args)
        {
            int M, N;

            Console.WriteLine("Informe o número de linhas (M): ");
            M = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de colunas (N): ");
            N = int.Parse(Console.ReadLine());

            int[,] matrizA = new int[M, N];
            int[,] matrizB = new int[M, N];
            int[,] matrizC = new int[M, N];

            Console.WriteLine("Informe os elementos da primeira matriz A:");

            for (int i = 0; i < M; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matrizA[i, j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine("Informe os elementos da segunda matriz B:");

            for (int i = 0; i < M; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matrizB[i, j] = int.Parse(linha[j]);
                }
            }

            // Calcular a matriz C somando os elementos correspondentes de A e B
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine("Matriz gerada C:");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrizC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}