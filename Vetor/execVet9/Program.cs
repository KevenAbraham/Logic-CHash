namespace execVet9 {
    class Program {
        static void Main(string[] args) {
            int n;
            double minHeight = 9999999.0, maxHeight = 0.0;

            Console.WriteLine("Informe a quantidade de valores a serem lidos:");
            n = int.Parse(Console.ReadLine());

            double[] height = new double[n];
            char[] sex = new char[n];
            double heightWoman = 0.0, mediaHeightWoman = 0.0;
            int qtd = 0, manQtd = 0;

            Console.WriteLine("Informe a sua altura e o seu sexo [M, F]");
            for(int i = 0; i < n; i++) {
                string[] vetor = Console.ReadLine().Split(' ');
                height[i] = double.Parse(vetor[0]);
                sex[i] = char.ToUpper(vetor[1][0]);

                if(height[i] > maxHeight) {
                    maxHeight = height[i];
                }

                if (height[i] < minHeight) {
                    minHeight = height[i];
                }

                if(sex[i] == 'F') {
                    heightWoman = heightWoman + height[i];
                    qtd++;
                    mediaHeightWoman = heightWoman / qtd;
                }

                if(sex[i] == 'M') {
                    manQtd++;
                }
            }

            Console.WriteLine($"Menor altura = {minHeight:F2}");
            Console.WriteLine($"Maior altura = {maxHeight:F2}");
            Console.WriteLine($"Média das alturas das mulheres = {mediaHeightWoman:F2}");
            Console.WriteLine($"Quantidade de homens = {manQtd}");
            
        }
    }
}