using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_2
{
    class Quadrado
    {
        double lado;
        double area;

        public void SetLado(double p)
        {
            lado = p;
        }

        public double GetLado()
        {
            return lado;
        }

        public double GetArea()
        {
            return area;
        }

        public double CalcularArea()
        {
            area = lado * lado;
            return area;
        }

    }
}
