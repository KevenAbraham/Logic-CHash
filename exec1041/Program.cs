namespace exec1041 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("====================================");
            Console.WriteLine("          PLANO CARTESIANO          ");
            Console.WriteLine("====================================");

            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            } else if (x == 0) {
                Console.WriteLine("Eixo Y");
            } else if (y == 0) {
                Console.WriteLine("Eixo X");
            } else if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            } else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            } else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            } else {
                Console.WriteLine("Q4");
            }
        }
    }
} 