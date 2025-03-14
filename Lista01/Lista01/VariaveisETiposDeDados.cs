using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    public class VariaveisETiposDeDados
    {
        public void VariaveisDados()
        {
            int varInt = 100;
            string varString = "Olá mundo!";
            double varDoub = 5.50;
            float varFloat = 1.73f;
            bool varBoleano = true;

            Console.WriteLine($"Bem-vindo ao show das variáveis! \nInteiro: {varInt}. \nString: {varString}. \nDouble: {varDoub}. \nFloat: {varFloat}. \nBoleano: {varBoleano}");
        }

        public void ConversorCelsiusFahrenheit()
        {
            Console.WriteLine("\n---- CONVERSOR DE TEMPERATURA ----");
            Console.WriteLine("Insira a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double f = celsius * 33.8;
            Console.WriteLine($"\nA temperatura em Fahrenheit é {f}");

        }
    }
}
