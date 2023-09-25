namespace exec1 {
    class Program {
        static void Main(string[] args) {
            int pass;

            Console.WriteLine("Informe a senha");
            pass = int.Parse(Console.ReadLine());

            while(pass != 2002) {
                Console.WriteLine("Informe a senha");
                pass = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
            
        }
    }
}