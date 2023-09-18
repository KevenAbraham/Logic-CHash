namespace exec1074 {
    internal class Program {
        public static void Main(string[] args) {
            int num, num2;

            Console.WriteLine("Informe um valor: ");
            num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i--) {
                num2 = int.Parse(Console.ReadLine());
                if (num2 % 2 == 0) {
                    if (num2 < 0) {
                        Console.WriteLine("EVEN NEGATIVE");
                    } else {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                } else {
                    if (num2 < 0) {
                        Console.WriteLine("ODD NEGATIVE");
                    } else {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }

                if (num2 == 0) {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}