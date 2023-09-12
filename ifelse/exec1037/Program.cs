namespace exec1037 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("===========================================");
            Console.WriteLine("      INFORME UM VALOR DE 0 A 100          ");
            Console.WriteLine("===========================================");

            double num = double.Parse(Console.ReadLine());

            if (num <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            } else if (num <= 50.0) {
                Console.WriteLine("Intervalo [25,50]");
            } else if (num <= 75.0) {
                Console.WriteLine("Intervalo [50,75]");
            } else if (num <= 100.0 ) {
                Console.WriteLine("Intervalo [75,100]");
            } else {
                Console.WriteLine("Fora de Intervalo");
            }

        }
    }
}