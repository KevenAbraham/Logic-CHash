namespace exec1115 {
    internal class Program {
        static void Main(string[] args) {
            int x, y;

            Console.WriteLine("Informe os planos cartesianos");
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                } else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                } else {
                    Console.WriteLine("Quarto");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                }
            }
        }
    }
}