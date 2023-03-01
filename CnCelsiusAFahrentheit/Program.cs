using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnCelsiusAFahrentheit
{
    internal class Program
    {
        /// <summary>
        ///nombre:Juan Esteban Ortiz Rendon
        ///Fecha:28/08/2023
        ///Descripcion:Algoritmo para realizar conversion de temperatura celsius a fahrentheir y viceversa
        ///</summary>


        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor escoja un tipo de convercion de temperatura:");
            Console.WriteLine("1-Celsios a Fahrenheit");
            Console.WriteLine("2-Fahrenheit a Celsios");
            int Eleccion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Porfavor escriba el valor de la temperatura segun la convercion que desee realizar");
            //Temp se refiere a temperatura
            double Temp = Convert.ToDouble(Console.ReadLine());

            if (Eleccion == 1)
                Console.WriteLine("El valor de su temperatura en celsios convertida en un valor de temperatura de fahremheit es de:" + PasoaFahrenheit(Temp));
            else
                Console.WriteLine("El valor de su temperatura en fahrenheit convertida en un valor de temperatura de celsius es de:" + PasoaCelsios(Temp));


            Console.ReadKey();
        }
        static double PasoaFahrenheit(double Temp)
        {
            double Conver;
            Conver = (Temp * 1.8) + 32;
            return Conver;
        }
        static double PasoaCelsios(double Temp)
        {
            double Conver;
            Conver = (Temp - 32) / 1.8;
            return Conver;
        }

    }



    }
