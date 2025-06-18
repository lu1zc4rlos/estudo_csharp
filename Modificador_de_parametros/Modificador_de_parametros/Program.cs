using System;

namespace Modificador_de_parametros {
    class Program {
        static void Main(string[] args) {

            // Exemplo de uso do modificador params
            int a = Calculator.Soma(10, 20, 30, 40 );
            Console.WriteLine(a);

            // Exemplo de uso do modificador ref
            int b = 10;
            Calculator.Triple(ref b);
            Console.WriteLine(b);

            // Exemplo de uso do modificador out
            int c = 10;
            int resultado;
            Calculator.Triplo(c, out resultado);
            Console.WriteLine(resultado);



        }


    }

}
