using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAula45CSharp {
    class Retangulo {

        public double Area(double larguraRet, double alturaRet) {
            double area = larguraRet * alturaRet;
            return area;
        }

        public double Perimetro(double larguraRet, double alturaRet) {
            double perimetro = (larguraRet + alturaRet) * 2;
            return perimetro;
        }

        public double Diagonal(double larguraRet, double alturaRet) {
            double diagonal = Math.Sqrt(Math.Pow(larguraRet, 2) + Math.Pow(alturaRet, 2));
            return diagonal;
        }
    }
}
