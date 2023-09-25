namespace exec1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("|=====================================================|");
            Console.WriteLine("|   Código   |        Lanche          |     Valor     |");
            Console.WriteLine("|=====================================================|");
            Console.WriteLine("|     1      |     Cachorro Quente    |     R$4,00    |");
            Console.WriteLine("|     2      |     X-Salada           |     R$4,50    |");
            Console.WriteLine("|     3      |     X-Bacon            |     R$5,00    |");
            Console.WriteLine("|     4      |     Torrada Simples    |     R$2,00    |");
            Console.WriteLine("|     5      |     Refrigerante       |     R$1,50    |");
            Console.WriteLine("|=====================================================|");

            int cod, qtd;
            
            Console.WriteLine("\nCódigo e quantidade:");
            string[] vet = Console.ReadLine().Split(' ');
            cod = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);
            
            double total;

            switch(cod) {
                case 1:
                    total = qtd * 4.00;
                    Console.WriteLine($"Total: R${total:F2}");
                    break;
                case 2:
                    total = qtd * 4.50;
                    Console.WriteLine($"Total: R${total:F2}");
                    break;
                case 3: 
                    total = qtd * 5.00;
                    Console.WriteLine($"Total: R${total:F2}");
                    break;
                case 4:
                    total = qtd * 2.00;
                    Console.WriteLine($"Total: R${total:F2}");
                    break;
                case 5:
                    total = qtd * 1.50;
                    Console.WriteLine($"Total: R${total:F2}");
                    break;
            }

        }
    }
}