namespace Exercico_matriz {
    public class Program {
        static void Main(string[] args) {
            Console.Write("Qual sera a ordem da matriz: ");
            int ordem = int.Parse(Console.ReadLine());

            int[,] matriz = new int[ordem, ordem];

            for (int i = 0; i < ordem; i++) {

                string[] linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < ordem; j++) {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0; i < ordem; i++) {
                Console.Write($"{matriz[i,i]}\t");
            }

            int negativos = 0;
            for (int i = 0; i < ordem; i++) {
                for (int j = 0; j < ordem; j++) {
                    if (matriz[i,j] < 0) {
                        negativos += 1;
                    }
                }
            }

            Console.WriteLine($"\nNegativos = {negativos}");
        }
    }
}