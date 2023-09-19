using System;

namespace exec1035 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("===================================================================");
            Console.WriteLine("                       LEITOR DE VALORES                           ");
            Console.WriteLine("===================================================================");

            Console.WriteLine("\nInforme os 4 valores:");
            String[] vet = Console.ReadLine().Split(' ');
            
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            int d = int.Parse(vet[3]);

            if (b > c && d > a) {
                if ((c + d) > (a + b)) {
                    if (a % 2 == 0) {
                        Console.WriteLine("Valores aceitos!");
                    }
                }
            } else {
                Console.WriteLine("Valores não aceitos.");
            }
        }
    }
}