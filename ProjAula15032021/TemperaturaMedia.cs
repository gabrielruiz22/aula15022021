using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula15032021
{
    class TemperaturaMedia
    {
        static void Main(string[] args)
        {
            Cidade c = new Cidade();
            double maior = 0, menor = 0, media = 0;

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Informe a " + (i + 1) + "ª temperatura: ");
                c.AdicionarTemperatura(decimal.Parse(Console.ReadLine()), i);
                
            }

            Console.WriteLine(c.MaiorEMenorTemp());
            Console.WriteLine("A media da temp foi: " + c.TemperaturaMedia());

            Console.ReadKey();
        }
    }
}
