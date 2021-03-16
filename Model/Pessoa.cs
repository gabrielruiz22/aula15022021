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
        
        public int NumeroDeFilhos { get; set; }
        public decimal Salario { get; set; }
        #endregion

        #region Métodos

        public int TransformarEmDias()
        {
            return this.Anos * QtdDiasDoAno +  this.Meses * QtdDiasDoMes + this.Dias;
        }

        public override string ToString()
        {
            return "Sua idade em dias é: " + TransformarEmDias();
        }
        #endregion
    }
}
