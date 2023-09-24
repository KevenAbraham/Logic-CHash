namespace exec1046 {
    internal class Program {
        public static void Main(string[] args) { 
            Console.WriteLine("==============================================================");
            Console.WriteLine("                        DURAÇÃO DO JOGO                       ");
            Console.WriteLine("==============================================================");

            Console.WriteLine("Informe a hora de início do jogo e a hora final:");
            string[] vet = Console.ReadLine().Split(' ');

            int inicio = int.Parse(vet[0]);
            int fim = int.Parse(vet[1]);

            int maior = 0;
            int menor = 0;

            if (inicio > fim) {
                maior = inicio;
                menor = fim;
            } 

            if (fim > inicio) {
                maior = fim;
                menor = inicio;
            }

            int totalHour = (24 + menor) - maior;

            Console.WriteLine($"O Jogo durou um total de {totalHour} horas.");

        }
    }
}