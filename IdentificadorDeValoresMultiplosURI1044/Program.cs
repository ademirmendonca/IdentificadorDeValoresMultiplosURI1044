using System;

namespace IdentificadorDeValoresMultiplosURI1044
{
    class Program
    {
        static void Main(string[] args)
        {
            //Captura os dados e recorta a string
            string[] vet = Console.ReadLine().Split(' ');

            //Aponta aonde cada valor separado por espaço será armazenado
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);            

            //Condição para identificação se os valores são multiplos ou não
            if ((a % b == 0) || (b % a == 0))
            {
                Console.WriteLine("Sao Multiplos");
            }

            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
