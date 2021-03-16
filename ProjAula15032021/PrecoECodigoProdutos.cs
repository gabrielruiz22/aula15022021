using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula15032021
{
    class PrecoECodigoProdutos
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            decimal media = 0, maior = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Informe o preço do " + (i + 1) + "º produto: ");
                decimal precoProduto = decimal.Parse(Console.ReadLine());
                
                Console.Write("Informe o código do produto: ");
                string codigoProduto = Console.ReadLine();

                p.AdicionarProduto(new Produto()
                {
                    Codigo = codigoProduto,
                    Preco = precoProduto
                }, i);
            }

            Console.WriteLine("produto mais cara custa: " + p.MediaDosPrecos());
            Console.WriteLine("A media de preço foi: " + p.ProdutoMaisCaro());
            Console.ReadKey();
        }
    }
}
