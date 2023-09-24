namespace execVet3 {
    class Program {
        static void Main(string[] args) {
            int n;

            int[] a, b, c;

            Console.WriteLine("Informe a quantidade de valores que irá inserir nos vetores");
            n = int.Parse(Console.ReadLine());

            int[] vetorA = new int[n];
            int[] vetorB = new int[n];
            int[] vetorC = new int[n];

            string[] elementosA = Console.ReadLine().Split(' ');
            string[] elementosB = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++) {
                vetorA[i] = int.Parse(elementosA[i]);
                vetorB[i] = int.Parse(elementosB[i]);
                vetorC[i] = vetorA[i] + vetorB[i];
            }

            foreach(int elemento in vetorC) {
                Console.Write(elemento + " ");
            }
        }
    }
}