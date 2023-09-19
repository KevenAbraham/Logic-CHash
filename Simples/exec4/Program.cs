namespace exec4 {
    internal class Program {
        public static void Main(string[] args) {
            int a, b, soma;

            Console.WriteLine("Informe o primeiro valor a ser somado: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor a ser somado: ");
            b = int.Parse(Console.ReadLine());

            soma = a + b;
            
            Console.WriteLine("A soma entre os valores " + a + " e " + b + " é igual à: " + soma);
        }
    }
}