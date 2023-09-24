using System.Globalization;

namespace exec1040 {
    internal class Program {
        public static void Main(string[] args) {
            double media;
            
            Console.WriteLine("===============================================");
            Console.WriteLine("               CÁLUCLO DE MÉDIA                ");
            Console.WriteLine("===============================================");

            Console.WriteLine("\nInforme a primeira nota:");
            float n1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("\nInforme a segunda nota:");
            float n2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("\nInforme a terceira nota:");
            float n3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("\nInforme a quarta nota:");
            float n4 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;          

            if (media >= 7.0) {
                Console.WriteLine($"O(a) Aluna(a) foi APROVADO(A), com {media:F1} de média.");
            } else if (media >= 5.0 && media <= 6.9) {
                Console.WriteLine("\n=====================================");
                Console.WriteLine("    Informe a nota de recuperação    ");
                Console.WriteLine("=====================================");
                
                float exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                media = (media + exame) / 2;

                if (media >= 5.0) {
                    Console.WriteLine($"O(a) Aluno(a) foi APROVADO(A) com {media:F1} de média.");
                } else {
                    Console.WriteLine($"O(a) Aluno(a) foi REPROVADO(A) com {media:F1} de média.");
                }
            } else {
                Console.WriteLine($"O(a) Aluno(a) foi REPROVAdO(A) com {media:F1} de média");
            }
        }
    }
}