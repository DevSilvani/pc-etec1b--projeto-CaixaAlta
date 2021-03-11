using System;

namespace pc_etec1b__projeto_CaixaAlta
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            Console.Write("Digite uma frase: ");
            nome = Console.ReadLine();

            Console.WriteLine(nome.ToUpper());
            Console.ReadKey();
        }
    }
}
