namespace exec1072 {
    internal class Program {
        public static void Main(string[] args) {
            int x, y, maior, menor;

            Console.WriteLine("Informe o primeiro valor:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro valor:");
            y = int.Parse(Console.ReadLine());

            if (x > y) {
                maior = x;
                menor = y;
            } else {
                maior = y;
                menor = x;
            }

            int soma = 0;
            for (int i = menor + 1; i < maior; i++) {
                soma = soma + i;
            }

            Console.WriteLine(soma);
        }
    }
}