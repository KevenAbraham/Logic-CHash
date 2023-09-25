namespace exec1 {
    class Program {
        static void Main(string[] args) {
            int cod1, qtd1, qtd2, cod2;
            double price1, price2;

            Console.WriteLine("1ª Peça -> Informe o código, a quantidade e o valor:");
            string[] vet = Console.ReadLine().Split(' ');

            cod1 = int.Parse(vet[0]);
            qtd1 = int.Parse(vet[1]);
            price1 = double.Parse(vet[2]);

             Console.WriteLine("2ª Peça -> Informe o código, a quantidade e o valor:");
            string[] vetor = Console.ReadLine().Split(' ');

            cod2 = int.Parse(vetor[0]);
            qtd2 = int.Parse(vetor[1]);
            price2 = double.Parse(vetor[2]);

            double totalPrice = (qtd1 * price1) + (qtd2 * price2);

            Console.WriteLine($"Total a pagar: {totalPrice:F2}");
        }
    }
}