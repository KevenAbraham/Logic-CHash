using System;
using System.Globalization;

namespace exec1 {
    internal class Program {
        public static void Main(string[] args) {

            Console.WriteLine("Informe o seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Nome Completo: " + nomeCompleto);

            Console.WriteLine("Quantos quartostem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de quartos: " + quartos);

            Console.WriteLine("Entre com o valor do produto: R$");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            Console.WriteLine("Preço do produto: R$" + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Informe o seu último nome, idade e altura (respectivamente):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("\nUltimo nome: " + ultNome);
            Console.WriteLine("Sua idade: " + idade);
            Console.WriteLine("Sua altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}