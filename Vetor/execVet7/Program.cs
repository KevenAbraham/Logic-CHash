using System;

namespace execVet7 {
    class Program {
        static void Main(string[] args) {
            int n, maiorIdade = 0;
            string nomeMaiorIdade = "";

            Console.Write("Informe a quantidade de pessoas: ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Informe o nome da pessoa {i + 1}:");
                nome[i] = Console.ReadLine();

                Console.WriteLine($"Informe a idade da pessoa {i + 1}:");
                idade[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++) {
                if (idade[i] > maiorIdade) {
                    maiorIdade = idade[i];
                    nomeMaiorIdade = nome[i];
                }
            }

            Console.WriteLine($"Pessoa mais velha: {nomeMaiorIdade}");
        }
    }
}