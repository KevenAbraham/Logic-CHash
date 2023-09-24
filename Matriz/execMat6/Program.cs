namespace execMat6 {
    class Progrm {
        static void Main(string[] args) {
            int N;

            Console.WriteLine("Informe a ordem da matriz quadrada (N): ");
            N = int.Parse(Console.ReadLine());

            double[,] matriz = new double[N, N];

            Console.WriteLine("Informe os elementos da matriz:");

            for (int i = 0; i < N; i++) {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = double.Parse(linha[j]);
                }
            }

            double somaPositivos = 0.0;
            int linhaEscolhida = 0;
            int colunaEscolhida = 0;

            Console.WriteLine("SOMA DOS POSITIVOS:");

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] > 0) {
                        somaPositivos += matriz[i, j];
                    }
                }
            }

            Console.WriteLine(somaPositivos);

            Console.WriteLine("Informe o índice da linha desejada: ");
            linhaEscolhida = int.Parse(Console.ReadLine());

            Console.WriteLine("LINHA ESCOLHIDA:");

            for (int j = 0; j < N; j++) {
                Console.Write(matriz[linhaEscolhida, j] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Informe o índice da coluna desejada: ");
            colunaEscolhida = int.Parse(Console.ReadLine());

            Console.WriteLine("COLUNA ESCOLHIDA:");

            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i, colunaEscolhida] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("DIAGONAL PRINCIPAL:");

            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA:");

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] < 0) {
                        matriz[i, j] *= matriz[i, j];
                    }
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}