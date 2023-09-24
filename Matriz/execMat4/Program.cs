namespace execMat4 {
    class Program {
        static void Main(string[] args) {
            int n;

            Console.WriteLine("Informe a ordem da matriz quadrada: ");
            n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            int somaAcimaDiagonalPrincipal = 0;
            for (int i = 0; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    somaAcimaDiagonalPrincipal += matriz[i, j];
                }
            }

            Console.WriteLine(somaAcimaDiagonalPrincipal);
        }
    }
}