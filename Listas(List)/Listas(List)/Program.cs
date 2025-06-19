using System;
using System.Collections.Generic;

namespace Listas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string> {"Luiz","Maria","Carlos","Fernando","Ana","Caio"};

            foreach (string item in list2) {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n-------------------------------------------------------------\n");

            // Adicionando elementos na lista
            Console.WriteLine("Adicionando elementos na lista: Add");
            list2.Add("Cristina");
            foreach (string item in list2) {
                Console.WriteLine(item);
            }
            // Inserindo elementos na lista
            Console.WriteLine("\nInserindo elementos na lista: Insert");
            list2.Insert(0, "João");
            foreach (string item in list2) {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n-------------------------------------------------------------\n");

            // Tamanho da lista
            Console.WriteLine("Tamanho da lista: Count");
            Console.WriteLine($"Tamanho da lista: {list2.Count}");
            Console.WriteLine("\n-------------------------------------------------------------\n");

            // Encontra primeiro ou ultimo elemento da lista que satisfaça uma condição
            Console.WriteLine("Encontra primeiro ou ultimo elemento da lista que satisfaça uma condição: Find e FindLast");
            string primeiro = list2.Find(x => x[0] == 'C');
            Console.WriteLine($"Primeiro elemento que começa com 'C': {primeiro}");
            string ultimo = list2.FindLast(x => x[0] == 'C');
            Console.WriteLine($"Último elemento que começa com 'C': {ultimo}");
            Console.WriteLine("\n-------------------------------------------------------------\n");

            // Encontra primeiro ou ultimo posição do elemento da lista que satisfaça uma condição
            Console.WriteLine(" Encontra primeiro ou ultimo posição do elemento da lista que satisfaça uma condição: FindIndex e FindLastIndex");
            int pos1 = list2.FindIndex(x => x[0] == 'C');
            Console.WriteLine($"Primeiro elemento que começa com 'C': {pos1}");
            int pos2 = list2.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine($"Último elemento que começa com 'C': {pos2}");
            Console.WriteLine("\n-------------------------------------------------------------\n");

            // Filtrar lista com base em uma condição
            Console.WriteLine("Filtrar lista com base em uma condição: FindAll");
            List<string> filtrada = list2.FindAll(x => x[0] == 'C');
            foreach (string item in filtrada) {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n-------------------------------------------------------------\n");

            // Removendo elementos da lista
            Console.WriteLine(" Removendo elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange");
            list2.Remove("Cristina");
            Console.WriteLine("Removendo 'Cristina':");
            foreach (string item in list2) {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n-------------------------------------------------------------\n");
            list2.RemoveAll(x => x[0] == 'C');
            Console.WriteLine("Removendo todos os elementos que começam com 'C':");
            foreach (string item in list2) {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n-------------------------------------------------------------\n");
            list2.RemoveAt(0);
            Console.WriteLine("Removendo o primeiro elemento:");
            foreach (string item in list2) {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n-------------------------------------------------------------\n");
            list2.RemoveRange(0, 2);
            Console.WriteLine("Removendo os dois primeiros elementos:");
            foreach (string item in list2) {
                Console.WriteLine(item);
            }
        }
    }
}