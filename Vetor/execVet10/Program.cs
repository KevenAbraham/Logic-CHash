namespace execVet10 {
    class Program {
        static void Main(string[] args) {
            int n;
            
            Console.Write("Informe a quantida de produtos a serem lidos: ");
            n = int.Parse(Console.ReadLine());

            string[] product = new string[n];
            double[] buyPrice = new double[n];
            double[] sellPrice = new double[n];
            double totalBuy = 0.0, totalSell = 0.0;            

            for(int i = 0; i < n; i++) {
                string[] array = Console.ReadLine().Split(' ');
                product[i] = array[0];
                buyPrice[i] = double.Parse(array[1]);
                sellPrice[i] = double.Parse(array[2]);
                totalBuy = totalBuy + buyPrice[i];
                totalSell = totalSell + sellPrice[i];
            }

            int lucro10 = 0, lucro20 = 0, lucroMore20 = 0;
            double[] lucro = new double[n];

            for(int i = 0; i < n; i++) {
                lucro[i] = ((sellPrice[i] - buyPrice[i]) / buyPrice[i]) * 100;

                if(lucro[i] < 10) {
                    lucro10++;
                } else if (lucro[i] >= 10 && lucro[i] <= 20) {
                    lucro20++;
                } else {
                    lucroMore20++;
                }
            }

            Console.WriteLine($"Lucro abaixo de 10%: {lucro10}");
            Console.WriteLine($"Lucro entre de 10% e 20%: {lucro20}");
            Console.WriteLine($"Lucro acima de 20%: {lucroMore20}");
            Console.WriteLine($"Valor total de compra: R${totalBuy:F2}");
            Console.WriteLine($"Valor total de venda: R${totalSell:F2}");
            Console.WriteLine($"Lucro total: R${(totalSell - totalBuy):F2}");

        }
    }
}