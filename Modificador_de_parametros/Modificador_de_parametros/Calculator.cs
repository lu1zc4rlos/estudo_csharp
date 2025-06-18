namespace Modificador_de_parametros {
    public class Calculator {
        public static int Soma(params int[] vet) {
            int Total = 0;
            for (int i = 0; i < vet.Length; i++) {
                Total += vet[i];
            }
            return Total;

            /* 
               Ultilizando o modificador params permite que você passe um valor variavel, assim independente da 
             quantidade de numeros que você passar, ele iran somar

               Até a verbalização do código, fica mais simples, exemplo sem o modificador params:
                   int a = Calculator.Soma(new int[] { 10, 20, 30, 40 });
                   Console.WriteLine(a);

               Com o modificador params:
                    int a = Calculator.Soma(10, 20, 30, 40);
                    Console.WriteLine(a);
             */
        }

        public static void Triple(ref int x) {
            x *= 3;

            /* 
                O modificador ref permite que você passe uma variavel por referencia, ou seja, se você alterar o valor
              da variavel dentro do método, o valor original também sera alterado.

                Exemplo de uso:
                int a = 10;
                Calculator.Triple(ref a);
                Console.WriteLine(a); // Saída: 30

            */
        }

        public static void Triplo(int origin, out int resultado) {
           
            resultado = origin * 3;

            /*
                O modificador out é semelhante ao ref, mas é usado quando você quer garantir que a variável
              será inicializada dentro do método. Você não precisa inicializar a variável antes de passá-la.

                Exemplo de uso:
                Calculator.Triple(out int a);
                Console.WriteLine(a); // Saída: 30
            */
        }
    }
}
