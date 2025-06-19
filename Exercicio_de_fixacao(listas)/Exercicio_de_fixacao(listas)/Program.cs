using Exercicio_de_fixacao_listas_;

namespace Exercicio_de_fixacao_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios seram registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> funcionarios = new List<Funcionarios>();
            for (int a = 0; a < n; a++) {
                Console.WriteLine($"Emplyoee #{a+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                funcionarios.Add(new Funcionarios(id, name, salario));
            }

            Console.Write("Digite o id do funcionario que tera o salario aumentado: ");
            int idAumento = int.Parse(Console.ReadLine());
            bool idEncontrado = false;
            foreach (Funcionarios obj in funcionarios) {
                if (obj.Id == idAumento) {
                    Console.Write("Qual a porcentagem do aumento: ");
                    double porcentagem = double.Parse(Console.ReadLine());
                    obj.Salario = obj.Salario + (obj.Salario * porcentagem / 100);
                    idEncontrado = true;
                }
            }
            if (!idEncontrado) {
                Console.WriteLine("Id nao encontrado!");
            } 

            Console.WriteLine("\nLista de funcionarios:");
            foreach (Funcionarios obj in funcionarios) {
                Console.WriteLine(obj);
            }

        }
    }
}
