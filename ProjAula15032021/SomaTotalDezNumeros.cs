using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula15032021
{
    class SomaTotalDezNumeros
    {
        static void Main(string[] args)
        {
            Numero soma = new Numero();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o " + (i + 1) + "Nº: ");
                soma.InserirNumero(int.Parse(Console.ReadLine()), i);
            }

            Console.WriteLine("A soma de todos os nº foi: " + soma.Somar());
            Console.ReadKey();
        }
    }
}
