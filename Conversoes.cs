using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    
    /// <summary>
    /// Implementa operações de conversão
    /// </summary>
    internal class static Conversoes
    {

                 /// <summary>
                /// Tipo de conversão de temperqtura a executar
                /// </summary>
                public enum ConversaoTemperatura
            {
                Nulo = 0,
                CelsiusFahrenheit,
                FahrenheitCelsius
            }
    }

///<summary> Tipo de conversão de temperatura </summary> 

public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
                {
                    if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
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

