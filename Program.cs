using System;
using System.Collections.Generic;
namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Clear();
            List<int> numeros = new List<int>();
            numeros.Add(333);
            numeros.Add(55);
            numeros.Add(11);
            numeros.Add(22);

            foreach (var item in numeros)
            {   
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            List<string> nomes= new List<string>();
            nomes.Add("Romildo");
            nomes.Add("Maria");
            nomes.Add("Aparecida");
            nomes.Add("Dorinha");

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
            foreach (var item in nomes)
            {
                if (item == "Romildo")
                {
                    Console.WriteLine("Nome encontrado");
                }
            }
            Console.WriteLine("");
            bool resposta = nomes.Contains("Cora coralina"); // procura numa lista e retorna verdadeiro ou falso
            if(resposta)
            {
                Console.WriteLine("nome encontrado");
            }
            else
            {
                Console.WriteLine("Nome não encontrado");
            }
            Console.WriteLine("");
            Console.WriteLine(nomes.Count); // conta quantos valores foram cadastrados numa lista

            for (var i = 0; i < nomes.Count; i++)
            {
                if(nomes[i] == "Aparecida")
                {
                    nomes.Insert(4,"Cida"); // Insere o valor em uma determinada posição
                    nomes.Remove("Aparecida"); // Remove um valor
                }
            }
            Console.WriteLine("");
            nomes.Sort(); // utilizado para organizar, no caso ordem alfabetica
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
