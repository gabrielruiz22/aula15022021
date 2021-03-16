using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula15032021
{
    class HabitantesCidade
    {
        static void Main(string[] args)
        {
            double mediaSalario = 0, mediaFilho = 0, maior = 0, menor150 = 0, perc = 0;
            Cidade c = new Cidade();

            for (int i = 0; i < c.listHabitantes.Length; i++)
            {
                Console.Write("Informe seu salario: ");
                decimal salario = decimal.Parse(Console.ReadLine());

                Console.Write("Informe quantos filhos tem: ");
                int filhos = int.Parse(Console.ReadLine());

                c.AdicionarHabitante(new Pessoa()
                {
                    NumeroDeFilhos = filhos,
                    Salario = salario
                }, i);
            }

            Console.WriteLine("\nO maior salario foi: " + c.MaiorSalarioHab());
            Console.WriteLine("A media de filho foi: " + c.MediaNumeroDeFilhos());
            Console.WriteLine("A media de salario foi: " + c.MediaSalarioPopulacao());
            Console.WriteLine("A porcentagem de pessoas que ganham menos de 150 foi: " + c.PercentualMenor150() + "%");

            Console.ReadKey();
        }
    }
}
