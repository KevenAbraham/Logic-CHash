namespace exec3 {
    internal class Program {
        public static void Main(string[] args) {
            double n = 3.14159, A, R;
       
            Console.WriteLine("Informe o valor de R:");
            R = double.Parse(Console.ReadLine());
        
            A = Math.Pow(R, 2) * n;
        
            Console.WriteLine("A = " + A);
        }
    }
}