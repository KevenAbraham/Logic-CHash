namespace ExemploArray {
    internal class Program {
        static void Main(string[] args) {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine()); //Leio a quantidade de casas que desejo armazenar dados.
            vet = new double[N]; // informo que o Vetor terá a quantidade de N que foi imputado pelo teclado.

            for (int i = 0; i < N; i++) { //Laço para inserir os valores dentro do vetor.
                vet[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++) { //Laço para exibir todos os valores dentro do vetor.
                Console.WriteLine(vet[i].ToString("F1"));
            }
        }
    }
}