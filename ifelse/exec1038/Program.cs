using System;

namespace exec1038 {
    internal class Program {
        public static void Main(string[] args) {
            double price = 0;
            
            Console.WriteLine("=========================================================");
            Console.WriteLine("  CODE   |       SPECIFICATION         |      PRICE      ");
            Console.WriteLine("=========================================================");
            Console.WriteLine("    1    |      Cachorro Quente        |     R$  4,00    ");
            Console.WriteLine("    2    |         X - Salada          |     R$  4,50    ");
            Console.WriteLine("    3    |         X - Bacon           |     R$  5,00    ");
            Console.WriteLine("    4    |      Torrada Simples        |     R$  2,00    ");
            Console.WriteLine("    5    |        Refrigerante         |     R$  1,50    ");
            Console.WriteLine("=========================================================");

            Console.WriteLine("Informe o código do seu pedido e a quantidade dele:");
            string[] vet = Console.ReadLine().Split(' ');

            int order = int.Parse(vet[0]);
            int quantity = int.Parse(vet[1]);

            switch (order) {
                case 1:
                    Console.WriteLine($"Pedido: {quantity} Cachorro quente");
                    price = 4.00 * quantity;
                    break;
                case 2:
                    Console.WriteLine($"Pedido: {quantity} X - Salada");
                    price = 4.50 * quantity;
                    break;
                case 3:
                    Console.WriteLine($"Pedido: {quantity} X - Bacon");
                    price = 5.00 * quantity;
                    break;
                case 4:
                    Console.WriteLine($"Pedido: {quantity} Torrada Simples");
                    price = 2.00 * quantity;
                    break;
                case 5:
                    Console.WriteLine($"Pedido: {quantity} Refrigerante");
                    price = 1.50 * quantity;
                    break;
                default:
                    Console.WriteLine("Valor inválido.");
                    break;
            }

            Console.WriteLine($"Total R${price:F2}");
        }
    }
}