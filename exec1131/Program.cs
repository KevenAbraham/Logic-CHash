namespace exec1131 {
    internal class Program {
        public static void Main(string[] args) {
            int gremio = 0, inter = 0, op = 1, vitGremio = 0, vitInter = 0, empate = 0, totalGrenal = 0;

            Console.WriteLine("=========================================");
            Console.WriteLine("                  GRENAL                 ");
            Console.WriteLine("=========================================");

            // vitGremio = 0;
            // vitInter = 0;
            // empate = 0;
            // totalGrenal = 0;
            // op = 1;

            while (op == 1) {
                Console.WriteLine("Informe o placar do GRENAL");
                string[] vet = Console.ReadLine().Split(' ');
                gremio = int.Parse(vet[0]);
                inter = int.Parse(vet[1]);
            
                if (gremio > inter) {
                    vitGremio++;
                } else if (inter > gremio) {
                    vitInter++;
                } else {
                    empate++;
                }
                totalGrenal++;

                Console.WriteLine("\nDeseja inserir mais placares? [1 - sim | 2 - não]");
                op = int.Parse(Console.ReadLine());

                while (op != 1 && op != 2) {
                    Console.WriteLine("Por favor, informe com apenas 1 e 2");
                    op = int.Parse(Console.ReadLine());
                }

                if (op == 2) {
                    break;
                }
            }

            Console.WriteLine($"{totalGrenal} Grenais");
            Console.WriteLine($"Vitórias Inter: {vitInter}");
            Console.WriteLine($"Vitórias Grêmio: {vitGremio}");
            Console.WriteLine($"Empates: {empate}");

            if (vitGremio > vitInter && vitGremio > empate) {
                    Console.WriteLine("Grêmio venceu mais!");
                } else if (vitInter > vitGremio && vitInter > empate) {
                    Console.WriteLine("Inter venceu mais!");
                } else {
                    Console.WriteLine("Não houve vencedor!");
                }
        }
    }
}