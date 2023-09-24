namespace exec1117 {
    internal class Program {
        static void Main(string[] args) {
            double n1, n2, media;

            Console.WriteLine("========================================");
            Console.WriteLine("             NOTAS DOS ALUNOS           ");
            Console.WriteLine("========================================");

            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            
            while (n1 < 0 || n1 > 10.0) {
                Console.WriteLine($"Digite a primeira nota certa");
                n1 = double.Parse(Console.ReadLine());                
            }
            
            while (n2 < 0 || n2 > 10.0) {
                Console.WriteLine($"Digite a segunda nota certa");
                n2 = double.Parse(Console.ReadLine());
            }

            media = (n1 + n2) / 2.0;

            Console.WriteLine($"A nota do aluno foi {media:F2}");
        }
    }
}