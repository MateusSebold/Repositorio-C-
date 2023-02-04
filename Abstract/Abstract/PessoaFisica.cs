using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract {
    sealed class PessoaFisica : Pessoa{

        public double GastosComSaude { get; set; }
        
        

        public PessoaFisica(string name, double renda,double gastosComSaude) :base(name,renda) {
            GastosComSaude = gastosComSaude;
        }

        public override double Imposto() {
            if(Renda <20000)
                return Renda * 0.15 - GastosComSaude*0.5;
            else
                return Renda * 0.25 - GastosComSaude * 0.5;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(Imposto());
            return sb.ToString();
        }

    }
}
