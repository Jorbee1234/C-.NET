using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Produto
    {
        private string nome; // Criando as variaveis no privado para proteger o acesso
        private double preco;
        private int quantidade;


        public string Nome { get; set; } //Encapsulamento por Properties
        public double Preco { get; set; } //Encapsulamento por Properties
        public int Quantidade { get; set; } //Encapsulamento por Properties



        public Produto(string nome, double preco, int quantidade) //Fazendo os construtores (estudando conceito)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
        
        public Produto() //Criando um construtor vazio para receber informação do program
        {
        }

        /*
        public string GetNome() //Sem utilidade criado somente para o treino de encapsulamento
        {
            return nome;
        }
        
        public double GetPreco()//Sem utilidade criado somente para o treino de encapsulamento
        {
            return preco;
        }

        public int GetQuantidade()//Sem utilidade criado somente para o treino de encapsulamento
        {
            return quantidade;
        }

        public void SetNome (string nome)//Sem utilidade criado somente para o treino de encapsulamento
        {
            this.nome = nome;
        }

        public void SetQuantidade(int quantidade)//Sem utilidade criado somente para o treino de encapsulamento
        {
            this.quantidade = quantidade;
        }

        public void SetPreco(double preco)//Sem utilidade criado somente para o treino de encapsulamento
        {
            this.preco = preco;
        }*/

        public void InfomarValores() //Estudando
        { //Fazer com que o usúario possa digitar as informações
            Console.WriteLine("Coloque informações do produto:");
            Console.WriteLine("Informe o nome do produto:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o Preco:");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Quantidade:");
            quantidade = int.Parse(Console.ReadLine());
        }
        
        public void alteracao()
        {//Fazer com que aconteceça uma alteração na quantidade
            string valor;
            int qntd;
            Console.WriteLine("Deseja fazer alguma alteração referente a quantidade?");
            Console.WriteLine("Digite a alteração que deseja fazer : Adicionar , Remover ou Nenhuma");
            valor = Console.ReadLine();
            if (valor == "Adicionar" || valor == "adicionar")//Consulta se a alteração será feita e será feita caso digite "Adicionar"
            {
                Console.WriteLine("Informe a quantidade que será adicionada: ");
                qntd = int.Parse(Console.ReadLine());
                quantidade += qntd;
            }
            else if (valor == "Remover" || valor == "remover")//Consulta se a altereção será feita e será feita caso digite "Remover"
            {
                Console.WriteLine("Informe a quantidade que será removido: ");
                qntd = int.Parse(Console.ReadLine());
                quantidade -= qntd;
            }
            else if (valor == "Nenhum" || valor == "nenhum")//Consulta se não terá alteração para seguir normalmente
            {
                Console.WriteLine("Quantidade não alterada!");
            }
            else //Foi digitado de maneira errada.
            {
                Console.WriteLine("Informação Invalida");
                alteracao();
            }
        }

        public void exibir()//Printa na tela as informações
        {
            Console.WriteLine ("Produto: " + nome + " , " + preco + " Reais , " + quantidade + " unidades") ;
        }
    }
}
