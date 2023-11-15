using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyOOP2 {
    internal class Funcionario {
        public string Nome {  get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
            this.SalarioBruto += (SalarioBruto * porcentagem / 100);
        }
    }
}
