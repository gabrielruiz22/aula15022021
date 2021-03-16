using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numero
    {
        #region Propriedades
        public int[] listNumero = new int[10];
        public int N { get; set; }
        public int Inicio = 15;
        public int Fim = 100;
        #endregion

        #region Método
        public void InserirNumero(int numero, int i)
        {
            listNumero[i] = numero;
        }
        
        public int Somar()
        {
            int soma = 0;
            for(int i = 0; i < listNumero.Length; i++)
            {
                soma = soma + listNumero[i];
            }
            return soma;
        }

        public void ImprimirSequenciaDeNumeros()
        {
            for (int i = 1; i <= this.N; i++)
            {
                Console.WriteLine("\n" + i);
            }
        }
        
        public decimal MediaAritmetica()
        {
            decimal soma = 0, qtd = 0; ;
            for (int i = this.Inicio; i <= this.Fim; i++)
            {
                soma += i;
                qtd++;
            }
            return soma / qtd;
        }
        #endregion

    }
}
