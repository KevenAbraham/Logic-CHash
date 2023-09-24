namespace exec1071 {
    internal class Program {
        public static void Main(string[] args) {
            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y) {
                max = x;
                min = y;
            } else {
                min = x;
                max = y;
            }

            soma = 0;
            for (int i = min + 1; i < max; i++) { //contagem começa com min + 1 pq o próprio valor nao entra na contagem.
                if (i % 2 != 0) {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}