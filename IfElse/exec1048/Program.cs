using System.Globalization;

namespace exec21 {
    internal class Program {
        public static void Main(string[] args) {
            double newSalary, increase, salary;
            int percent;

            Console.WriteLine("=====================================================");
            Console.WriteLine("                 REAJUSTE DE SALÁRIO                 ");
            Console.WriteLine("=====================================================");

            Console.WriteLine("Informe o seu salário atual:");
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary <= 400.00) {
                increase = salary * 0.15;
                newSalary = salary + increase;
                percent = 15;
            } else if (salary <= 800.00) {
                increase = salary * 0.12;
                newSalary = salary + (salary * 0.12);
                percent = 12;
            } else if (salary <= 1200.00) {
                increase = salary * 0.10;
                newSalary = salary + (salary * 0.10);
                percent = 10;
            } else if (salary <= 2000.00) {
                increase = salary * 0.07;
                newSalary = salary + (salary * 0.07);
                percent = 7;
            } else {
                increase = salary * 0.04;
                newSalary = salary + (salary * 0.04);
                percent = 4;
            }

            Console.WriteLine($"Novo salário: R${newSalary:F2}\nReajuste ganho: R${increase:F2}\nEm percentual: {percent}%");


        }
    }
}