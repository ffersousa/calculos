using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
            Console.WriteLine  ($"4+2 = {Aritmetica.Somar(4,2)}2");
            Console.WriteLine($"4-2= {Aritmetica.Subtrair(4, 2)}");

            Double t1= Conversoes.ConverterTemperatua(Conversoes.ConversaoTemperatura.CelsiusFharenheit, 36);
            Double t2= Conversoes.ConverterTemperatua(Conversoes.ConversaoTemperatura.FahrenheitCelsius, 100);
            
            Console.WriteLine($36º Celsius = {t1}º Fahrenheit);
            Console.WriteLine($100º Fahrenheit = {t2}º Fahrenheit);


            Console.ReadKey();
        }
    }
}
