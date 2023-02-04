using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract {
    abstract class Pessoa {

        public string Nome { get; set; }
        public double Renda { get; set; }


        public Pessoa(string nome, double renda) {
            Nome = nome;
            Renda = renda;
        }

        public abstract double Imposto();

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome);
            sb.Append(": $ ");
            return sb.ToString();
        }
    }
}
