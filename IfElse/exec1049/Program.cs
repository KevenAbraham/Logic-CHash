namespace exec1049 {
    internal class Program {
        static void Main(string[] args) {
            string animal;
            Console.WriteLine("======================================");
            Console.WriteLine("                ANIMAL                ");
            Console.WriteLine("======================================");

            Console.WriteLine("Informe: Vertebrado ou Invertebrado.");
            string op1 = Console.ReadLine();

            if (op1 == "vertebrado") {
                Console.WriteLine("\nInforme: Ave ou Mamífero.");
                string op2 = Console.ReadLine();
                if (op2 == "ave") {
                    Console.WriteLine("\nInforme: Carnívoro ou Onívoro.");
                    string op3 = Console.ReadLine();
                    if (op3 == "carnivoro") {
                        animal = "Águia";
                        Console.WriteLine($"O animal escolhido foi: {animal}");
                    } else {
                        animal = "Pomba";
                        Console.WriteLine($"O animal escolhido foi: {animal}");
                    }
                } else if (op2 == "mamifero") {
                    Console.WriteLine("\nInforme: Onívoro ou Herbívoro.");
                    string op3 = Console.ReadLine();
                    if (op3 == "onivoro") {
                        animal = "Homem";
                        Console.WriteLine($"O animal escolhido foi: {animal}");
                    } else {
                        animal = "Vaca";
                        Console.WriteLine($"O animal escolhido foi: {animal}");
                    }
                }
            } else if (op1 == "invertebrado") {
                Console.WriteLine("\nInforme: Inseto ou Anelídeo.");
                string op2 = Console.ReadLine();
                if (op2 == "inseto") {
                    Console.WriteLine("\nInforme: Hematofago ou Herbívoro.");
                    string op3 = Console.ReadLine();
                    if (op3 == "hematofago") {
                        animal = "Pulga";
                        Console.WriteLine($"O animal escolhido foi: {animal}");
                    } else {
                        animal = "Lagarta";
                        Console.WriteLine($"O animal escolhido foi: {animal}");
                    }
                } else if (op2 == "herbivoro") {
                    Console.WriteLine("\nInforme: Hmetofago ou Onívoro.");
                    string op3 = Console.ReadLine();
                    if (op3 == "hematofago") {
                        animal = "Sanguessuga";
                        Console.WriteLine($"O animal escolhido foi: {animal}");
                    } else {
                        animal = "Minhoca";
                        Console.WriteLine($"O animal escolhido foi: {animal}");
                    }
                }
            }
        }
    }
}