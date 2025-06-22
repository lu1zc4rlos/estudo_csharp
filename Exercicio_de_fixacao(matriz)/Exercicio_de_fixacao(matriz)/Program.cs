namespace Exercicio_de_fixacao_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de linhas: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de colunas: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            for (int n = 0; n < linhas; n++) {
                string[] vetor = Console.ReadLine().Split(' ');

                for (int x = 0; x < colunas; x++) {
                    matriz[n, x] = int.Parse(vetor[x]);
                }
               
            }

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            
            for (int linha = 0; linha < linhas; linha++) {
                for (int coluna = 0; coluna < colunas; coluna++) {
                    if (matriz[linha, coluna] == numero) {

                        Console.WriteLine($"Position {linha},{coluna}:");

                        if (coluna > 0) {
                            Console.WriteLine($"Left: {matriz[linha, coluna - 1]}");
                        }   
                        if (coluna < colunas-1) { 
                            Console.WriteLine($"Right: {matriz[linha, coluna + 1]}");
                        }
                        if (linha > 0) {
                            Console.WriteLine($"Up: {matriz[linha - 1, coluna]}");
                        }
                        if (linha < linhas-1) {
                            Console.WriteLine($"Down {matriz[linha + 1, coluna]}");
                        }

                    }
                }
            }
        }
    }
}