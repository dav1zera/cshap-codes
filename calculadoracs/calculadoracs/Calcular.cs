using System;
using System.Collections.Generic;


namespace calculadoracs
{
    class Calcular {
    
        static double Calculate (double x, char oper, double y)
        {

            switch (oper)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '*':
                    return x * y;
                case '/':
                    return x / y;
                default:
                    return 0.0;
            }
        }

        internal double Calcular(double x, char oper, double y)
        {
            throw new NotImplementedException();
        }
    }
}
