using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula15032021
{
    class LerValoresInteiros
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();

            Console.Write("Informe um numero:");
            numero.N = int.Parse(Console.ReadLine());

            while (numero.N == 0)
            {
                Console.WriteLine("O numero tem que ser maior que ZERO!");
                Console.Write("Informe um numero:");
                numero.N = int.Parse(Console.ReadLine());
            }

            numero.ImprimirSequenciaDeNumeros();
            Console.ReadKey();
        }
    }
}
