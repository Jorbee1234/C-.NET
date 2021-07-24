using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entidades
{
    class Empregado
    {
        public string Nome { get; set; } //Está fazendo um Properties
        public int Horas { get; set; } //Está fazendo um Properties
        public double ValorHr { get; set; } //Está fazendo um Properties

        public Empregado()
        {
        }
        public Empregado(string nome, int horas, double valorHr)// Fazendo um construtor
        {
            Nome = nome;
            Horas = horas;
            ValorHr = valorHr;
        }

        public virtual double Pagamento() //Virtual é utilizado para que ela possa ser sobreescrita na função FuncTec
        {
            return Horas * ValorHr;
        }
    }
}
