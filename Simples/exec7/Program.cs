using System.Globalization;

namespace exec7 {
    internal class Program {
        public static void Main(string[] args) {
            double p1, p2, p3, media;

            Console.WriteLine("Informe a primeira nota do aluno:");
            p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a segunda nota do aluno:");
            p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a terceira nota do aluno:");
            p3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (p1 + p2 + p3) / 3;

            Console.WriteLine("A média das notas é igual a: " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}