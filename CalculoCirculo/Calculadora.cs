using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoCirculo
//Rafael Do Nascimento Rodrigues RA 210211
{
    class Calculadora
    {
        //declarando variavel Pi
        public double Pi = 3.14;
        //calculo da Circuferencia
        public double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        //Calculo do volume
        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
