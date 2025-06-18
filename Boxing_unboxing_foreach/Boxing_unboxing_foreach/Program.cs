using System;
using System.Collections.Generic;

namespace Boxing_unboxing_foreach {
    class Program {
        static void Main(string[] args) {
           
            int number = 42;
            object boxedNumber = number;
            // Esse processo é chamado de boxing, onde um tipo de valor (int) é convertido em um tipo de referência (object).     
            
            int unboxedNumber = (int)boxedNumber;
            // Esse processo é chamado de unboxing, onde um tipo de referência (object) é convertido de volta para um tipo de valor (int).

            Console.WriteLine($"Original: {number}, Boxed: {boxedNumber}, Unboxed: {unboxedNumber}");

            // Laço de repetição Foreach 
            List<string> nomes = new List<string> { "Alice", "Bob", "Charlie" };

            // O laço foreach é usado para iterar sobre uma coleção de elementos, como uma lista ou um array.
            foreach (string name in nomes) {
                // "var name é um nome que você da para cada elemento da lista nomes, assim sendo,
                //  cada elemento da lista nomes é chamado de name e consequentimente sendo executado a sua lógica
                //  entre chaves"
                Console.WriteLine(name);
            }
        }
    }
}   
