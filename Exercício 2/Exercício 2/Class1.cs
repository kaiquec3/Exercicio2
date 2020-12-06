using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_2
{
    class Quadrado
    {
        #region Atributos
        double lado;
        double area;
        #endregion

        #region Construtores
        public Quadrado()
        {
            this.lado = 0;
            this.area = 0;
        }

        public Quadrado(double lado)
        {
            this.lado = lado;
            this.area = 0;
        }
        #endregion

        #region Setters e Getters
        public void SetLado(double lado)
        {
            this.lado = lado;
        }

        public double GetLado()
        {
            return this.lado;
        }

        public double GetArea()
        {
            return this.area;
        }

        #endregion

        #region Métodos funcionais
        public double CalcularArea()
        {
            this.area = this.lado * this.lado;
            return this.area;
        }

        public double CalcularArea(double lado)
        {
            this.area = lado * lado;
            return this.area;

        }
        #endregion
    }
}