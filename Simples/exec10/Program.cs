using System.Globalization;

namespace exec10 {
    internal class Program {
        public static void Main(string[] args) {
            // Produto 1
            Console.WriteLine("Informe o código do produto 1: ");
            int codProd1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade do produto: ");
            int quantityProd1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do produto: ");
            double priceProd1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalPriceProd1 = quantityProd1 * priceProd1; 
            
            // Produto 2
            Console.WriteLine("Informe o código do produto 2: ");
            int codProd2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade do produto: ");
            int quantityProd2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do produto: ");
            double priceProd2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalPriceProd2 = quantityProd2 * priceProd2; 

            double check = totalPriceProd1 + totalPriceProd2;

            //Produto 1
            Console.WriteLine("\nCódigo de Produto 1: " + codProd1);
            Console.WriteLine("Unidade do Produto 1: " + quantityProd1);
            Console.WriteLine("Subtotal: R$" + totalPriceProd1.ToString("F2", CultureInfo.InvariantCulture));

            //Produto 2
            Console.WriteLine("\nCódigo de Produto 2: " + codProd2);
            Console.WriteLine("Unidade do Produto 2: " + quantityProd2);
            Console.WriteLine("Subtotal: R$" + totalPriceProd2.ToString("F2", CultureInfo.InvariantCulture));

            //Total a pagar
            Console.WriteLine("\nTotal: R$" + check.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}