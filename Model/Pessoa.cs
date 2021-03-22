using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        #region Propriedades
        public int Anos { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }
        public int QtdDiasDoAno = 365;
        public int QtdDiasDoMes = 30;

        public string nome { get; set; }
        public double altura { get; set; }
        public string sexo { get; set; }
        public double peso = 0;

        public int NumeroDeFilhos { get; set; }
        public decimal Salario { get; set; }
        #endregion

        #region Métodos

        public int TransformarEmDias()
        {
            return this.Anos * QtdDiasDoAno +  this.Meses * QtdDiasDoMes + this.Dias;
        }

        public double calculaIMC()
        {
            if (this.sexo == "M")
            {
                this.peso = (72.7 * this.altura) - 58;
            }
            else
            {
                this.peso = (62.1 * this.altura) - 44.7;
            }
            return this.peso;
        }

        public override string ToString()
        {
            return "Sua idade em dias é: " + TransformarEmDias();
        }
        #endregion
    }
}
