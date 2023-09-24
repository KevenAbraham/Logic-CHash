namespace execMat7 {
    class Program {
        static void Main(string[] args) {
            int M, N;
            Console.WriteLine("Informe o número de filas (M): ");
            M = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de soldados por fila (N): ");
            N = int.Parse(Console.ReadLine());

            int[][] pelotao = new int[M][];
            for (int i = 0; i < M; i++) {
                Console.WriteLine($"Informe os {N} soldados da fila {i + 1}:");
                string[] soldados = Console.ReadLine().Split(' ');
                pelotao[i] = new int[N];
                for (int j = 0; j < N; j++) {
                    pelotao[i][j] = int.Parse(soldados[j]);
                }
            }

            Console.WriteLine("Informe o número da fila para o exercício 'girar fila': ");
            int filaParaGirar = int.Parse(Console.ReadLine());

            // Realiza o exercício "girar fila"
            int[] filaGirada = new int[N];
            for (int i = 0; i < N; i++) {
                int posicaoAnterior = (i - 1 + N) % N;
                filaGirada[i] = pelotao[filaParaGirar - 1][posicaoAnterior];
            }

            Console.WriteLine("Formação do pelotão após o exercício 'girar fila':");

            // Imprime a formação do pelotão após o exercício
            for (int i = 0; i < M; i++) {
                if (i == filaParaGirar - 1) {
                    // Imprime a fila que foi girada
                    for (int j = 0; j < N; j++) {
                        Console.Write(filaGirada[j] + " ");
                    }
                }
                else {
                    // Imprime as outras filas sem alteração
                    for (int j = 0; j < N; j++) {
                        Console.Write(pelotao[i][j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}