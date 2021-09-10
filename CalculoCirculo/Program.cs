using System;
using System.Globalization;


namespace CalculoCirculo
{
    class Program
        //Rafael Do Nascimento Rodrigues RA 210211
    {
        //declarando variavel Pi
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            //Mostrar na tela para o usuario digitar o valor do raio
            Console.WriteLine("Entre com o valor do raio:");
            //ler o valor escrito e converter em double, declarando variável raio
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // declarando variavel circ (circuferencia)
            double circ = Circuferencia(raio);
            //declarando variavel volume (Volume)
            double volume = Volume(raio);

            //Conversão dos resultados para string, para ser possível mostra-los na tela
            Console.WriteLine("Circuferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        //calculo da Circuferencia
        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }
       //Calculo do volume
        static double Volume (double r)
        {
            return 4.0/3.0 * Pi * r*r*r;
        }
    }
}
