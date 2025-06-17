namespace Exercício_de_fixação_vetores_ {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos carros seram alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            DadosPessoais[] alugueis = new DadosPessoais[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                alugueis[quarto] = new DadosPessoais(nome, email, quarto);
                Console.Write("\n");

            }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 10; i++) {
                if (alugueis[i] != null) {
                    Console.WriteLine(alugueis[i]);
                }
            }

        }
    }
}