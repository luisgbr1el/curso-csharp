using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAula48CSharp {
    class ConversorDeMoeda {
        public static double Iof = 6.0;
        public static double Conversor(double dolar, double quantidade) {
            double convertido = dolar * quantidade;
            return convertido + convertido * Iof / 100.00;
        }
    }
}
