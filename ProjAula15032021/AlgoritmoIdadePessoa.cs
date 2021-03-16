using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula15032021
{
    class AlgoritmoIdadePessoa
    {
        static void Main(string[] args)
        {
            int qtdAnosIdade, qtdMesesIdade, qtdDiasIdade, idadeEmMeses, idadeEmDias;
            Console.WriteLine("Informe sua idade!");

            do
            {
                Console.Write("Anos: ");
                qtdAnosIdade = int.Parse(Console.ReadLine());

                if (qtdAnosIdade <= 0)
                {
                    Console.WriteLine("Não é possível ter anos menores que 0");
                }

            } while (qtdAnosIdade <= 0);

            do
            {
                Console.Write("Meses: ");
                qtdMesesIdade = int.Parse(Console.ReadLine());

                if (qtdMesesIdade < 0)
                {
                    Console.WriteLine("Não é possível ter meses negativos");
                }

            } while (qtdMesesIdade < 0);

            do
            {
                Console.Write("Dias: ");
                qtdDiasIdade = int.Parse(Console.ReadLine());

                if (qtdDiasIdade < 0)
                {
                    Console.WriteLine("Não é possível ter dias negativos");
                }

            } while (qtdDiasIdade < 0);

            Pessoa pessoa = new Pessoa()
            {
                Anos = qtdAnosIdade,
                Meses = qtdMesesIdade,
                Dias = qtdDiasIdade
            };

            Console.WriteLine(pessoa.ToString());

            Console.ReadKey();
        }
    }
}
