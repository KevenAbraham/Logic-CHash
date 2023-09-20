namespace ExemploForEach {
    class Program {
        static void Main(string[] args) {
            int n;

            n = int.Parse(Console.ReadLine());
            string[] vet = new string[n];

            for (int i = 0; i < n; i++) {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes Lidos:");
            foreach (string elemento in vet) { //elemento -> apelido do vetor
                Console.WriteLine(elemento);
            }

        }
    }
}