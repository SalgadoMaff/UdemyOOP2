using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyOOP2 {
    class ConversorMoeda {
        public static double IOF = 0.06;
        public static double DolarToReal(double cotacao, double qtdDol){
            double tot = cotacao * qtdDol;
            return tot + (IOF * tot);
        }
    }
}
