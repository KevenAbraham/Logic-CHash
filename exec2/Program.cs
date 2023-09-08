
namespace exec2 {
    internal class Program {
        public static void Main(string[] args) {
            int A, B, X;

            Console.WriteLine("Informe o primeiro valor da soma: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor da soma: ");
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("O resultado entre: " + A + " + " + B + " é igual a: " + X);
        }
    }
}