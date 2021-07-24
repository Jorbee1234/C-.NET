using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Empregado
    {

        public int Num {get; set; }//Está fazendo um Properties

        public string Nome { get; set; }//Está fazendo um Properties

        public double Salario { get; set; }//Está fazendo um Properties

        public Empregado(int num, string nome, double salario)//Esta fazendo o construtor
        {
            Num = num;
            Nome = nome;
            Salario = salario;
        }

        public void Calculo(double porcentagem) //Fazendo o calculo de porcentagem
        {
            Salario += Salario * porcentagem / 100;
        }
    }
}
