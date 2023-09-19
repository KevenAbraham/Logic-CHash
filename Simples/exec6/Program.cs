using System.Globalization;

namespace exec6 {
    internal class Program {
        public static void Main(string[] args) {
            double p1, p2, media; 

            Console.WriteLine("Informe a primeira nota: ");
            p1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a segunda nota: ");
            p2 = double.Parse(Console.ReadLine());

            media = (p1 + p2) / 2;

            Console.WriteLine("A média entre as notas é igual a: " + media);
        }
    }
} 