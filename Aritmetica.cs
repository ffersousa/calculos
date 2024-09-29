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
    class Aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperqtura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo= 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        /// <summary>
        /// Operação soma
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna a soma de 2 numeros</returns>
        public int Somar(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        ///  Operação de subtração
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna o resultado da subtração de 2 numeros</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        public double ConverterTemperatura(ConversaoTemperatura  conversao, double temperatura)
        {
            if (conversao== ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32)) / 1.800;
            }

            return -1;

        }

    }
}
