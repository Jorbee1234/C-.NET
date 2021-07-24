using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entidades
{
    class FuncTerc : Empregado // Os : é usado para ser feito a herança
    {

        public double Adicional { get; set; }

        //Essa basae é utilizado para puxar a função de pagamento feito no empregado, para não ser necessário a repetição do mesmo.
        public FuncTerc(string nome, int horas, double valorHr, double adicional) : base(nome,horas,valorHr)
        {
            Adicional = adicional;
        }
        //Efetuando a conta para ser feito o valor do adicional
        public override double Pagamento()
        {
            return Horas * ValorHr + 1.1 * Adicional; 
        }
    }
}
