using System;
using System.Collections.Generic;//Para poder usar a Lista

//Nesse prograa o usuário vai entrar com a quantidade de funcionários, informar quem são e irá dar um aumento para o funcionário desejado por ele.
//Só poderá adicionar aumento para 1 funcionário, os funcionários seram alocados na lista

namespace Lista
{
    // Exercicio para praticar a Lista e o Encapsulamento.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de funcionários para serem registrados :"); //Digitar a quantidade de funcionário
            int n = int.Parse(Console.ReadLine());

            List<Empregado> list = new List<Empregado>(); //Criar a lista

            for(int i = 0; i < n; i++) //Para o usuario digitar as informações
            {
                Console.WriteLine("Empregado: " + i + " : ");
                Console.WriteLine("Número de identificação: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Empregado(num, nome, salario));
            }
            Console.WriteLine();
            Console.WriteLine("Digite o nome do funcionario que vai receber aumento: ");
            int info = int.Parse(Console.ReadLine());

            Empregado empregado = list.Find(x => x.Num == info); // Find irá procurar dentro da lista o funcionário que possui o Numero que irá receber aumento
            // Dentro do parentese é uma das maneiras de mostrar para o find que o elemento que ele precisa procurar tem que ser referente a info digitada pelo usuario

            if(empregado != null) //Caso o valor do número seja encontrado ele irá adicionar o aumento
            {
                Console.WriteLine();
                Console.WriteLine("Entre com a porcentagem:");
                double porc = double.Parse(Console.ReadLine());
                empregado.Calculo(porc);
            }
            else
            {
                Console.WriteLine("Número inexistente!");
            }
            Console.WriteLine();
            Console.WriteLine("Lista de funcionario com a atualização: ");

            for (int i = 0; i < n; i++) //Mostra a lista na tela
                Console.WriteLine(" Número: " + empregado.Num + " Nome: " + empregado.Nome + " Salario: " + empregado.Salario );
        }
    }
}
