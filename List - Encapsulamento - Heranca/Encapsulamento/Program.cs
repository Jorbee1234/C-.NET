using System;

namespace Encapsulamento
{
    class Program
    {
        //Duas maneiras de execução colocando os comentários para serem ativdados ou deixando todos os comandos exibidos
        
        //Exercicio somente para o usúario digitar o nome de um produto (nome,quantidade e preco), alterar a quantidade e exibir as informações
        
        //Treino para encapsulamento em C#

        static void Main(string[] args)
        {
            Produto testando = new Produto();

            testando.InfomarValores();
            testando.alteracao();
            testando.exibir();

            /*
            Console.WriteLine("Coloque informações do produto:");
            Console.WriteLine("Informe o nome do produto:");
            testando.Nome = Console.ReadLine();
            Console.WriteLine("Informe o Preco:");
            testando.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Quantidade:");
            testando.Quantidade = int.Parse(Console.ReadLine());

            string valor;
            int qntd;
            Console.WriteLine("Deseja fazer alguma alteração referente a quantidade?");
            Console.WriteLine("Digite a alteração que deseja fazer : Adicionar , Remover ou Nenhuma");
            valor = Console.ReadLine();
            if (valor == "Adicionar" || valor == "adicionar")
            {
                Console.WriteLine("Informe a quantidade que será adicionada: ");
                qntd = int.Parse(Console.ReadLine());
                testando.Quantidade += qntd;
            }
            else if (valor == "Remover" || valor == "remover")
            {
                Console.WriteLine("Informe a quantidade que será removido: ");
                qntd = int.Parse(Console.ReadLine());
                testando.Quantidade -= qntd;
            }
            else if (valor == "Nenhum" || valor == "nenhum")
            {
                Console.WriteLine("Quantidade não alterada!");
            }
            else
            {
                Console.WriteLine("Informação Invalida");
            }

            Console.WriteLine("Produto: " + testando.Nome + " , " + testando.Preco + " Reais , " + testando.Quantidade + " unidades");
            */
        }
    }
}

