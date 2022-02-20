using System;

namespace calcularTrian {  

class Triangulo  {

    public double ladoA;
    public double ladoB;
    public double ladoC;

        public double Area () {
        double p = (ladoA + ladoB + ladoC) / 2.0;
        return Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));

        }

    }

  }

 
