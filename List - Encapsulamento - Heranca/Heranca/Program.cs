using System;
using System.Collections.Generic; //Para poder usar a lista
using Heranca.Entidades; // Para poder usar entendidades 

namespace Heranca
{


    //Nesse exercicio de o usuário vai cadastrar o nome, hora e valor por hora, caso o funcionario seja tercerizado ele irá ganhar um adicional
    //O adicional é referente a um ganho de 110%

    class Program
    {
        //Exercicio referene a prática de Herança:
        static void Main(string[] args)
        {
            List<Empregado> list = new List<Empregado>(); // Criação da lista

            Console.Write("Informe o número do empregado: "); //Dizer a quantidade de funcionáros
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++) // Montar a lista de funcionários
            {
                Console.WriteLine("Empregado: " + i + " dados: ");
                Console.WriteLine("Funcionario tercerizado? s ou n");
                char resp = char.Parse(Console.ReadLine()); //O comando console.readline funciona diretamente com o strig então quando usar o char é necessario fazer o cast
                Console.WriteLine("Nome :");
                string nome = Console.ReadLine();
                Console.WriteLine("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora :");
                double valorHr = double.Parse(Console.ReadLine());

                if(resp == 's'|| resp == 'S') //Condicional para caso a resposta seja sim em relação a ser terceirizado
                {
                    Console.WriteLine("Valor extra :");
                    double valorEx = double.Parse(Console.ReadLine());
                    list.Add(new FuncTerc(nome, horas, valorHr, valorEx)); //Adiciona na lista os valores que estão dento do parenteses
                }
                else //Condicional para caso a resposta seja não em relação a ser terceirizado
                {
                    list.Add(new Empregado(nome, horas, valorHr)); // Adiciona na lista os valores que estão dentro do parenteses
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos :");
            foreach (Empregado emp in list)//Para cada funcionário da lista
            {
                Console.WriteLine("Nome do funcionario: " + emp.Nome + "Salario: " + emp.Pagamento() + "Reais");
            }


        }
    }
}
