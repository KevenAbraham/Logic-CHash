namespace exec1044 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("\n=============================================");
            Console.WriteLine("         Leitor de Valores Múltiplos         ");
            Console.WriteLine("=============================================");

            Console.WriteLine("\nInforme um valor e outro para conferir se são múltiplo.");
            string[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (b % a == 0) {
                Console.WriteLine("São múltiplos.");
            } else {
                Console.WriteLine("Não são múltiplos.");
            }
        }
    }
}