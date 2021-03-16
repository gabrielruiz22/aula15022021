using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Triangulo
    {
        #region Propriedades
        public int[] LadosTriangulo = new int[3];
        #endregion
        
        #region Métodos

        public void AdicionarLados(int indice, int ladoTriangulo)
        {
            LadosTriangulo[indice] = ladoTriangulo;
        }

        public Boolean ValidaLadosTriangulo()
        {

            if (LadosTriangulo[0] < (LadosTriangulo[1] + LadosTriangulo[2]))
            {
                if (LadosTriangulo[1] < (LadosTriangulo[2] + LadosTriangulo[0]))
                {
                    if (LadosTriangulo[2] < (LadosTriangulo[0] + LadosTriangulo[1]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}
