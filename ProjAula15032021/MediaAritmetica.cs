using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula15032021
{
    class MediaAritmetica
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();

            Console.WriteLine("A média foi: " + numero.MediaAritmetica());
            Console.ReadKey();
        }
    }
}
