namespace execmat1 {
    class Program {
        static void Main(string[] args) {
            int m, n;

            Console.Write("Informe a quantidade de linhas da matriz: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de colunas da matriz: ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];
            for(int i = 0; i < m; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++) {
                    mat[i,j] = int.Parse(vet[j]);
                }
            }

            Console.WriteLine("Valores negativos: ");
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    if(mat[i,j] < 0) {
                        Console.WriteLine(mat[i,j]);
                    }
                }
            }


        }
    }
}