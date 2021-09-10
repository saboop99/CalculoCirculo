using System;
using System.Globalization;


namespace CalculoCirculo
{
    class Program
        //Rafael Do Nascimento Rodrigues RA 210211
    {
        
        static void Main(string[] args)
        {
            /*Declaração e referencia da classe Calculadora
            Calculadora calc = new Calculadora();*/
            
            
            //Mostrar na tela para o usuario digitar o valor do raio
            Console.WriteLine("Entre com o valor do raio:");
            //ler o valor escrito e converter em double, declarando variável raio
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // declarando variavel circ (circuferencia)
            double circ = Calculadora.Circuferencia(raio);
            //declarando variavel volume (Volume)
            double volume = Calculadora.Volume(raio);

            //Conversão dos resultados para string, para ser possível mostra-los na tela, e depois é mostrado na tela
            Console.WriteLine("Circuferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        
    }
}
