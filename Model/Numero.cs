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
        public double maior, media;

        public double N1 { get; set; }
        public double N2 { get; set; }
        public double N3 { get; set; }
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

        public double verificaNumeros()
        {
            if (this.N1 > this.N2 && this.N1 > this.N3)
            {

                return this.maior = this.N1;
            }
            else if (this.N2 > this.N1 && this.N2 > this.N3)
            {

                return this.maior = this.N2;
            }
            else
            {
                return this.maior = N3;
            }

        }

        public string verificaTriangulo()
        {
            if (this.N1 < (this.N2 + this.N3))
            {
                if (this.N2 < (this.N3 + this.N1))
                {
                    if (this.N3 < (this.N1 + this.N2))
                    {

                        return "É um triangulo";
                    }
                    else
                    {

                        return "Não é um triangulo";
                    }
                }
                else
                {
                    return "Não é um triangulo";
                }
            }
            else
            {
                return "Não é um triangulo";
            }
        }
        #endregion

    }
}
