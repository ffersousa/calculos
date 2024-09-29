using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    ///<sumary>
    /// Implenta operações aritmeticas
    /// <sumary></sumary>
   internal static class Aritmetica
    {
       

        /// <summary>
        /// Operação soma
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna a soma de 2 numeros</returns>
        public static  int Somar(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        ///  Operação de subtração
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna o resultado da subtração de 2 numeros</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

        

    }
}
