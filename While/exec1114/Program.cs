namespace exec1114 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("===================================");
            Console.WriteLine("          LEITOR DE SENHA          ");
            Console.WriteLine("===================================");

            Console.WriteLine("Informe a sua senha:");
            int password = int.Parse(Console.ReadLine());

            while (password != 2002) {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("\nInforme a sua senha:");
                password = int.Parse(Console.ReadLine());
            } 

            Console.WriteLine("Acesso permitido");
        }
    }
}