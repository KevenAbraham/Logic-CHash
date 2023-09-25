namespace exec2 {
    class Program {
        static void Main(string[] args) {
            int num, n, _in = 0, _out = 0; 

            Console.WriteLine("Informe quantos números irá inserir: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                Console.WriteLine("\nInsira um número:");
                num = int.Parse(Console.ReadLine());
                if(num >= 10 && num <= 20) {
                    _in++;
                } else {
                    _out++;
                }
            }

            Console.WriteLine($"{_in} in");
            Console.WriteLine($"{_out} out");
        }
    }
}