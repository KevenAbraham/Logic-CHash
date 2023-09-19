namespace exec1134 {
    internal class Program {
        public static void Main(string[] args) {
            int gas = 0, alc = 0, diesel = 0;

            Console.WriteLine("======================================");
            Console.WriteLine("|      COMBUSTÍVEL PREFERIDO         |");
            Console.WriteLine("======================================");
            Console.WriteLine("|          1  -  Álcool              |");
            Console.WriteLine("|          2  -  Gasolina            |");
            Console.WriteLine("|          3  -  Diesel              |");
            Console.WriteLine("|          4  -  Finalizar           |");
            Console.WriteLine("======================================");

            Console.WriteLine("\nInforme o combustível desejado");
            int combustivel = int.Parse(Console.ReadLine());

            while (combustivel != 4) {
                switch (combustivel) {
                    case 1:
                        alc++;
                        break;
                    case 2:
                        gas++;
                        break;
                    case 3:
                        diesel++;
                        break;
                }
                
                Console.WriteLine("======================================");
                Console.WriteLine("|      COMBUSTÍVEL PREFERIDO         |");
                Console.WriteLine("======================================");
                Console.WriteLine("|          1  -  Álcool              |");
                Console.WriteLine("|          2  -  Gasolina            |");
                Console.WriteLine("|          3  -  Diesel              |");
                Console.WriteLine("|          4  -  Finalizar           |");
                Console.WriteLine("======================================");
                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Gasolina: {gas}");
            Console.WriteLine($"Diesel: {diesel}");
            Console.WriteLine($"Álcool: {alc}");
        }
    }
}