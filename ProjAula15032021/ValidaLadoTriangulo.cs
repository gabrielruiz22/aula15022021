using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula15032021
{
    class ValidaLadoTriangulo
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();

            
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Informe o " + (i+1) + "Nº: ");
                t1.AdicionarLados(i, int.Parse(Console.ReadLine()));  
            }
            ;

            if(t1.ValidaLadosTriangulo() == true)
            {
                Console.WriteLine("É um triangulo");
            }
            else
            {
                Console.WriteLine("Não é um triangulo");
            }
           
            Console.ReadKey();

        }
    }
}
