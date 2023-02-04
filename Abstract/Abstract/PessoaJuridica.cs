using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract {
    sealed class PessoaJuridica : Pessoa {
        
        public int Funcionario { get; set; }

        public PessoaJuridica(string nome , double renda,int funcionario) : base(nome,renda) {
            Funcionario = funcionario;
        }

        public override double Imposto() {
            if (Funcionario > 10)
                return Renda * 0.14;
            else
                return Renda * 0.16;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(Imposto());
            return sb.ToString();   
        }
    }
}
