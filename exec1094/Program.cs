namespace exec1094 {
    internal class Program {
        public static void Main(string[] args) {
            int num, totalAnimal = 0, numTeste, coelho = 0, rato = 0, sapo = 0;
            double percentualCoelho, percentualSapo, percentualRato;
            string animal;

            Console.WriteLine("Informe o valor de testes realizado:");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                Console.WriteLine("Informe a quantiade de testes e o animal:\nC - Coelho R - Rato S - Sapo");
                string[] vet = Console.ReadLine().Split(' ');

                numTeste = int.Parse(vet[0]);
                animal = vet[1];

                totalAnimal += numTeste;

                switch(animal) {
                    case "C":
                        coelho += numTeste;
                        break;
                    case "R":
                        rato += numTeste;
                        break;
                    case "S":
                        sapo += numTeste;
                        break;                    
                }
            }

            Console.WriteLine($"Total de animais: {totalAnimal}");
            Console.WriteLine($"Total de coelhos: {coelho}");
            Console.WriteLine($"Total de ratos: {rato}");
            Console.WriteLine($"Total de sapos: {sapo}");
            
            percentualCoelho = (coelho * 100.0) / totalAnimal;
            Console.WriteLine($"Percentual de Coelhos: {percentualCoelho:F2}");

            percentualRato = (rato * 100.0) / totalAnimal;
            Console.WriteLine($"Percentual de Ratos: {percentualRato:F2}");
            
            percentualSapo = (sapo * 100.0) / totalAnimal;
            Console.WriteLine($"Percentual de Spoa: {percentualSapo:F2}");
        }
    }
}